using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenant.conf;
using Tenant_BE;
using Tenant_BL;

namespace Tenant
{
    public partial class ucAddInquilino : UserControl
    {
        //Conexion Confifguracion
        jsconfig _jsfile = new jsconfig();
        url_conf urls = new url_conf();

        Documento_BL documento_BL;
        List<Documento_BE> listDocumentos = new List<Documento_BE>();
        bool switchAlfaNum = false; // false : numericos - true: alfanumericos
        Documento_BE docm;

        public ucAddInquilino()
        {
            InitializeComponent();
        }

        private void ucAddInquilino_Load(object sender, EventArgs e)
        {
            //Inicializado configuracion
            urls = _jsfile.ReadConfig();
            documento_BL = new Documento_BL(urls.urlService);
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            cboTypeInquil.Items.Add(new KeyValuePair<int, string>(0, "Domestico"));
            cboTypeInquil.Items.Add(new KeyValuePair<int, string>(1, "Comercial"));

            cboTypeInquil.DisplayMember = "Value";
            cboTypeInquil.ValueMember = "Key";

            cboTypeInquil.SelectedIndex = 0;

            listDocumentos.Clear();
            listDocumentos = documento_BL.ListDocumento();
            cboTipoDoc.DataSource = listDocumentos;
            cboTipoDoc.DisplayMember = "str_descrLarga";
            cboTipoDoc.ValueMember = "int_codDoc";

            cboTipoDoc.SelectedIndex = 0;
            ConfiguracionCboTipoDoc();

        }

        private void btnABack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Deseas descartar los datos ingresados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;

                this.txtAddApellidos.Text = String.Empty;
                this.txtAddNombres.Text = String.Empty;
                this.txtDireccion.Text = String.Empty;
                this.txtPdfDirectory.Text = String.Empty;
                this.txtDireccion.Text = String.Empty;
                this.txtPreTelefono.Text = String.Empty;
                this.txtTelefono.Text = String.Empty;
                this.txtNumDoc.Text = String.Empty;

                this.cboTypeInquil.SelectedIndex = 0;
                this.cboTipoDoc.SelectedIndex = 0;

                imgFoto.Image = null;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                try
                {
                    //  Cargar de la imagen inicial
                    Image originalImage = Image.FromFile(ofd.FileName);

                    //  Redimensionamiento de la imagen manteniendo la relación de aspecto
                    Image resizedImage = ResizeImageKeepingAspectRatio(originalImage, 175, 200);

                    //  Compresion y verificacion del tamaño en KB
                    //  No es necesario este paso, pero de igual manera para lograr establecer un tamaño maximo de la imagen.
                    byte[] compressedImage = CompressImage(resizedImage, 100); // 100 KB máximo

                    if (compressedImage.Length <= 100 * 1024)
                    {
                        //  **COMPRESION Y RESULTADO EXITOSO**
                        
                        // Traduccion del arry de bytes a Image para mostrar la imagen
                        Image imgFromCompressedBytes;
                        using (MemoryStream ms = new MemoryStream(compressedImage))
                        {
                            imgFromCompressedBytes = Image.FromStream(ms);
                        }

                        // Muestra la imagen comprimida en el PictureBox
                        imgFoto.Image = imgFromCompressedBytes;


                       
                        MessageBox.Show("Imagen cargada y comprimida correctamente");
                    }
                    else
                    {
                        // De igual forma se deja al aire, el mantener esta linea de codigo.
                        // Como no se logro la compresion, igual se envia la imagen redimensionada
                        imgFoto.Image = resizedImage;
                        // En teoria es imposible que una imagen 175x200 en formato JPEG, que es el que se uso en la compresion, exceda los 100KB
                        MessageBox.Show("No se pudo reducir el tamaño de la imagen a menos de 100 KB");
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("La imagen seleccionada no es un formato de imagen válido o está dañada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Metodo para redimensionar manteniendo la relacion de aspecto
        private Image ResizeImageKeepingAspectRatio(Image img, int maxWidth, int maxHeight)
        {
            int originalWidth = img.Width;
            int originalHeight = img.Height;

            //Calcular la nueva relación de aspecto
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            //Calcular el nuevo tamaño de la imagen
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            //Crear una imagen redimensionada
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        // Metodo para comprimir la imagen y asegurar que no exceda los 100 KB
        // Se cambia el formato de imagen JPEG, en el salto de Image -> byte[]
        private byte[] CompressImage(Image img, int maxKb)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //Calidad inicial establecida en 85%
                long quality = 85L;
                EncoderParameters encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                ImageCodecInfo jpegCodec = GetEncoder(ImageFormat.Jpeg);
                img.Save(ms, jpegCodec, encoderParams);

                // Se verifica si el tamaño es mayor a maxKb KB y ajustar la calidad si es necesario
                // El bucle se detiene cuando se llego ala compresion deseada (100KB) o cuando la calidad quality, llege a 10 que este
                // va reduciendose en cada iteracion (en este caso va de 5 en 5).
                while (ms.Length > maxKb * 1024 && quality > 10)
                {
                    //Reducir la calidad en 5
                    quality -= 5;
                    encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                    //Limpiar el MemoryStream y volver a guardar con menor calidad
                    ms.SetLength(0);
                    img.Save(ms, jpegCodec, encoderParams);
                }

                return ms.ToArray();
            }
        }

        //Metodo para obtener el codec de JPEG (se usa en la compresion)
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return b;
        }


        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguracionCboTipoDoc();
        }

        private void ConfiguracionCboTipoDoc()
        {
            try
            {
                int indexSelect = Convert.ToInt32(cboTipoDoc.SelectedValue.ToString());
                docm = listDocumentos.FirstOrDefault(e => e.int_codDoc == indexSelect);

                txtNumDoc.MaxLength = docm.int_long;
                if (docm.int_tipo == 5) switchAlfaNum = false;
                if (docm.int_tipo == 0) switchAlfaNum = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!switchAlfaNum)
            {
                // Caracteres numericos
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                // Caracteres alfanumericos
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPreTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
               !char.IsDigit(e.KeyChar) &&
               e.KeyChar != '(' &&
               e.KeyChar != ')' &&
               e.KeyChar != '+' &&
               e.KeyChar != '-')
            {

                e.Handled = true;
            }
        }

        private void btnDelImage_Click(object sender, EventArgs e)
        {
            imgFoto.Image = null;
        }
    }
}
