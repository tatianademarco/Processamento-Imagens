using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessamentodeImagem
{
    internal class Imagem
    {
        public Bitmap bitmap { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Imagem()
        {
        }

        public Bitmap CarregarImagem()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos os arquivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                bitmap = new Bitmap(imagePath);

                width = bitmap.Width;
                height = bitmap.Height;

                return bitmap;
            }
            return null;
        }
    }
}
