using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace wfa_JSON_DT
{
    public class ClsExtra
    {
        /// <summary>
        /// A seguir vejamos outra abordagem onde definimos um método para obter os dados 
        /// usando a classe WebRequest para fazer a requisição para a Uri e obter os dados 
        /// no formarto JSON deserializando para um DataTable:
        /// </summary>
        /// <param name="uri">O caminho completo da URL</param>
        /// <returns>Retorna um JSON deserializado</returns>
        public JArray GetRESTDados(string uri)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());

            string s = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<JArray>(s);
        }

        /// <summary>
        /// Função para procurar qual RadioButton foi escolhido
        /// </summary>
        /// <param name="controls">Procurar dentro deste controle</param>
        /// <returns>Retorna o Texto do RadioButton</returns>
        public string RetornaResource(Control controls)
        {
            string strRet = "";

            foreach (Control Ctr in controls.Controls)
            {
                if ((Ctr is RadioButton button) && (button.Checked))
                {
                    strRet = Ctr.Text;
                    break;
                }
            }

            return strRet;
        }
    }
}
