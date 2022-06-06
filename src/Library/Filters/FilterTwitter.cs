using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen , la publica en twitter y retorna la misma imagen.
    /// </remarks>
    public class FilterTwitter : IFilter
    {
        public int NumeroDePublicacion = 0;
        /// Un filtro que guarda una imagen, la publica en twitter y retorna  la imagen recibida.
        /// La guarda debido a que es necesario para utilizar la API de Twitter ya que la forma de publicar una imagen
        /// es enviandole el archivo.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida.</returns>
        public IPicture Filter(IPicture image)
        {
            TwitterImage twitter = new TwitterImage();
            PictureProvider p = new PictureProvider();
            string RutaDeGuardado = $"PasodeTwitter.jpg";
            p.SavePicture(image, RutaDeGuardado);
            twitter.PublishToTwitter($"PasoIntermedio Nro:{this.NumeroDePublicacion}", RutaDeGuardado);
            this.NumeroDePublicacion+=1;
            return image;
        }
    }
}