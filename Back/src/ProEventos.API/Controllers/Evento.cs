using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Evento : Controller
    {
        public IEnumerable<Models.Evento> _evento = new Models.Evento[]{
            new Models.Evento {
            EventoId = 1,
            DataEvento = DateTime.Now.AddDays(5),
            ImagemURL = "Foto1.jpg",
            Local = "Curitiba",
            Lote = "405",
            QtdPessoas = 20,
            Tema = "Samba"
            }   ,
            new Models.Evento {
            EventoId = 2,
            DataEvento = DateTime.Now.AddDays(8),
            ImagemURL = "Foto1.jpg",
            Local = "São Paulo",
            Lote = "405",
            QtdPessoas = 20,
            Tema = "Terror"
            }   ,
            new Models.Evento {
            EventoId = 3,
            DataEvento = DateTime.Now.AddDays(20),
            ImagemURL = "Foto1.jpg",
            Local = "Rio de Janeiro",
            Lote = "405",
            QtdPessoas = 20,
            Tema = "Anos 80"
            }   
        };

        [HttpGet]
        public Models.Evento Get(){
            return new Models.Evento(){
                EventoId = 1,
                Tema = "Tema Teste 1",
                Local="Curitiba",
                DataEvento = DateTime.Now.AddDays(20),
            };
        }

        [HttpGet("{id}")]
        public IEnumerable<Models.Evento> Get(int id){
            return _evento.Where(x=> x.EventoId == id);
        }

        [HttpPost]
        public string Post(){
            return "Exemplo de post";
        }
        [HttpPut("{id}")]
        public string Post(int id){
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Exemplo de Delete com id = {id}";
        }
    }
}