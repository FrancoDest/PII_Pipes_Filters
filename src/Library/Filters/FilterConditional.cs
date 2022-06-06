using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using TwitterUCU;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Filtro diseñado para ver si hay una cara o no en una imagen.
    /// </summary>
    public class FilterConditional : IFilter
    {
        /// <summary>
        /// Este atributo devuelve True o False dependiendo de si hay una cara en la imagen.
        /// </summary>
        public bool Conditional;
        /// <summary>
        /// Metodo de filtro donde entra y sale una imagen.
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        public IPicture Filter(IPicture picture)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(picture, "GuardadoCondicional.jpg");
            CognitiveFace cog = new CognitiveFace();
            cog.Recognize("GuardadoCondicional.jpg");
            this.Conditional = cog.FaceFound;
            return picture;
        }
        
    }
}