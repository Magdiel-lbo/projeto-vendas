using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetovendas.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<HomeModel> GetALL()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Name = "Magdiel";
            lista.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Name = "aluno";
            lista.Add(item);

            return lista;
        }
    }
}
