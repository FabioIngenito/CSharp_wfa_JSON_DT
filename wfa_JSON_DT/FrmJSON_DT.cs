using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

/// <summary>
/// BASEADO NO EXEMPLO DO MACORATTI:
/// C#-  Convertendo JSON para DataTable
/// http://www.macoratti.net/19/06/wf_jsondtb1.htm
/// 
/// Hoje veremos como converter dados no formato JSON para um DataTable exibindo as informações em um 
/// GridView em uma aplicação Windows Forms.
/// Neste artigo vamos consumir dados REST no formato JSON, e, como exemplo vou obter os dados do
/// serviço https://jsonplaceholder.typicode.com/ que fornece algumas APIs para podermos consumir.
/// 
/// {JSON} Placeholder - Veja como usar neste link:
/// https://jsonplaceholder.typicode.com/
/// </summary>
namespace wfa_JSON_DT
{
    public partial class FrmJSON_DT : Form
    {
        private readonly ClsExtra clsE = new ClsExtra();

        public FrmJSON_DT()
        {
            InitializeComponent();
        }

        private void FrmJSON_DT_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// O botão "BtnAcessar" irá fazer a deserialização da página indicada somando com o texto do RadioBUtton escolhido:
        /// posts      - 100 posts
        /// comments   - 500 comments
        /// albums     - 100 albums
        /// photos     - 5000 photos
        /// todos      - 200 todos
        /// users      - 10 users (ATENÇÃO: APRESENTA ERRO SOMENTE NO BOTÃO "BtnAcessar")
        /// EXTRA: "/" - Permite você colocar a URL da SUA ESCOLHA!
        /// 
        /// OUTRAS OPÇÔES:
        /// Routes
        /// All HTTP methods are supported.You can use http or https for your requests.
        ///     GET     /posts
        ///     GET	    /posts/1
        ///     GET     /posts/1/comments
        ///     GET	    /comments? postId = 1
        ///     POST    /posts
        ///     PUT	    /posts/1
        ///     PATCH   /posts/1
        ///     DELETE  /posts/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            string strURLCompleta, strJson;

            strURLCompleta = TxtURL.Text + clsE.RetornaResource(GrbResorces);
            strJson = new WebClient().DownloadString(strURLCompleta);
            //https://jsonplaceholder.typicode.com/users
            //https://jsonplaceholder.typicode.com/users
            DgvDados.DataSource = JsonConvert.DeserializeObject<DataTable>(strJson);
        }

        /// <summary>
        /// Agora basta chamar o método passando a Uri e retornando o datatable para o DataGridView:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAcessarREST_Click(object sender, EventArgs e)
        {
            DgvDados.DataSource = clsE.GetRESTDados(TxtURL.Text + clsE.RetornaResource(GrbResorces));
        }
    }
}
