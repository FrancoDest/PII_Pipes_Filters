using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen , la guarda en un archivo y retorna la misma imagen.
    /// </remarks>
    public class FilterSave : IFilter
    {
        public int NumeroDeGuardado = 0;
        /// Un filtro que guarda y retorna la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida }}.</returns>
        public IPicture Filter(IPicture image)
        {
            PictureProvider p = new PictureProvider();
            p.SavePicture(image, $"PasoIntermedio{this.NumeroDeGuardado}.jpg");
            this.NumeroDeGuardado+=1;
            return image;
        }
    }
}
