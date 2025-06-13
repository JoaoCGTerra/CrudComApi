using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaLogin;

namespace Dados.Clientes {

    public class UsuarioPF {

        private int id = Login.usuarioPFIndex;

        public int Id {
            get { return id; }

            set { id += 1; }
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNasc { get; set; }

        public string Tel { get; set; }

        public string Rua { get; set; }

        public string Num { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }


        public static List<UsuarioPF> ListUsuariosPF = new List<UsuarioPF>();


        public static UsuarioPF UserFinderPF(string cpf) {
            return ListUsuariosPF.Find(u => u.Cpf == cpf);
        }

        public static UsuarioPF UserFinderComboPF(int id) {
            return ListUsuariosPF.Find(u => u.Id == id);
        }

        public static bool UserDeletePF(UsuarioPF lista) {
            return ListUsuariosPF.Remove(lista);
        }
    }

}
