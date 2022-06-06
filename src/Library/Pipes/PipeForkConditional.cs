using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeForkConditional : IPipe
    {
        IPipe next2Pipe;
        IPipe nextPipe;
        
        /// <summary>
        /// La cañería recibe una imagen, y decide cual bifurcacion toma de las dos Pipes
        /// </summary>
        /// <param name="nextPipe">Siguiente cañeria con filtro</param>
        /// <param name="next2Pipe">Siguiente cañeria sin filtro</param>
        public PipeForkConditional(IPipe nextPipe, IPipe next2Pipe) 
        {
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;           
        }
        
        /// <summary>
        /// Este metodo recibe una imagen, utiliza el filtro condicional y dependiendo de si tiene una cara envia 
        /// a una de las dos pipes asignadas anteriormente en el constructor del pipe.
        /// </summary>
        /// <param name="picture">imagen a filtrar y enviar a una de las siguientes cañerías</param>
        public IPicture Send(IPicture picture)
        {
            FilterConditional filtroCondicional = new FilterConditional();
            filtroCondicional.Filter(picture);
            
            if (filtroCondicional.Conditional)
            {
                return next2Pipe.Send(picture.Clone());
            }
            
            return this.nextPipe.Send(picture);
        }
    }
}