using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string[] frases = new string[]
            {

                "A sustentabilidade é a chave para um futuro melhor.",
                "Cada pequena ação conta para proteger o meio ambiente.",
                "Vamos cuidar do nosso planeta para as futuras gerações.",
                "A sustentabilidade é um compromisso de todos nós.",
                "Juntos, podemos construir um mundo mais verde e sustentável.",
                "A sustentabilidade é um estilo de vida que promove o equilíbrio entre o meio ambiente, a sociedade e a economia.",
                 "Use transporte público sempre que possível.",
                "Evite o uso de plástico descartável.",
                "Economize água no dia a dia.",
                "Desligue aparelhos da tomada quando não estiver usando.",
                "Prefira produtos recicláveis."

         };
            Random random = new Random();
            int indice = random.Next(frases.Length);
            return frases[indice];
        }
    }
}