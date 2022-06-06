using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;


namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comente las distintas partes para que puedan verlas por separado eliminando 
            //los comentados de varias lineas a la vez. Con el objetivo de que sea mas facil la correccion.

            //Parte 1
            /*
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            string guardadofinal= (@"PasoFinal.jpg");

            PipeSerial filter1 = new PipeSerial(new FilterNegative(), new PipeNull());
            
            PipeSerial filter2 = new PipeSerial(new FilterGreyscale(), filter1);

            IPicture Finalimage = filter2.Send(picture);
            provider.SavePicture(Finalimage,guardadofinal);
            */
            
            //Parte 2
            
            /*
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            string guardadofinal= (@"PasoFinal.jpg");

            PipeSerial filter1 = new PipeSerial(new FilterNegative(), new PipeNull());

            PipeSerial filter2 = new PipeSerial(new FilterSave(), filter1);

            PipeSerial filter3 = new PipeSerial(new FilterGreyscale(), filter2);

            IPicture Finalimage = filter3.Send(picture);

            provider.SavePicture(Finalimage,guardadofinal);
            */

            //Parte 3
            //El filterTwitter tambien guarda la imagen, ya que los metodos utilizados
            //en twitter api funcionan dandole un archivo jpg no una imagen directamente
            /*
            PictureProvider provider = new PictureProvider();
            IFilter filtroDePublicacion = new FilterTwitter();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            string guardadofinal= (@"PasoFinal.jpg");

            PipeSerial filter1 = new PipeSerial(new FilterGreyscale(), new PipeNull());

            PipeSerial filter2 = new PipeSerial(filtroDePublicacion, filter1);
            
            PipeSerial filter3 = new PipeSerial(new FilterNegative(), filter2);

            PipeSerial filter4 = new PipeSerial(filtroDePublicacion, filter3);

            IPicture Finalimage = filter4.Send(picture); 
            provider.SavePicture(Finalimage,guardadofinal);
            */
            
            //Paso 4
            /*
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            string guardadofinal= (@"PasoFinal.jpg");

            PipeSerial filter1 = new PipeSerial(new FilterTwitter(), new PipeNull());
            PipeSerial filter1_1 = new PipeSerial(new FilterNegative(), new PipeNull());

            PipeForkConditional filter2 = new PipeForkConditional(filter1_1, filter1);
            
            PipeSerial filter3 = new PipeSerial(new FilterGreyscale(), filter2);
            
            IPicture ImagenFinal = filter3.Send(picture);
            provider.SavePicture(ImagenFinal, guardadofinal);
            */
        }
    }
}
