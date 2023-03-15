using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace biblio_app {
    public partial class AuthorsFom : Form {
        private DataSet _biblioDS;
        private SqlDataAdapter _authorsAdapter;

        public AuthorsFom() {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorCommand = connection.CreateCommand();
            authorCommand.CommandType = CommandType.Text;
            authorCommand.CommandText = "SELECT * FROM Authors";

            _biblioDS = new DataSet();
            _authorsAdapter = new SqlDataAdapter(authorCommand);
            _authorsAdapter.Fill(_biblioDS, "Authors");

            bindingSourceAuthors.DataSource = _biblioDS;
            bindingSourceAuthors.DataMember = "Authors";

            txtAuID.DataBindings.Add(new Binding("Text", bindingSourceAuthors, "Au_ID"));
            txtAuthorName.DataBindings.Add(new Binding(("Text"), bindingSourceAuthors, "Author"));
            txtYearBorn.DataBindings.Add(new Binding(("Text"), bindingSourceAuthors, "Year Born"));
        }

        private void btnFirst_click(object sender, EventArgs e) {
            bindingSourceAuthors.MoveFirst();
        }

        private void btnPrevious_click(object sender, EventArgs e) {
            bindingSourceAuthors.MovePrevious();
        }

        private void btnNext_click(object sender, EventArgs e) {
            bindingSourceAuthors.MoveNext();
        }

        private void btnLast_click(object sender, EventArgs e) {
            bindingSourceAuthors.MoveLast();
        }

        private void btnNew_click(object sender, EventArgs e) {
            bindingSourceAuthors.AddNew();
            SetAddNewUI();
        }

        private void btnEdit_click(object sender, EventArgs e) {
            SetEditUI();
        }

        private void btnDelete_click(object sender, EventArgs e) {
            if (MessageBox.Show("Delete?", "Biblio App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                bindingSourceAuthors.RemoveCurrent();
                bindingSourceAuthors.EndEdit();
            }
        }

        private void btnClose_click(object sender, EventArgs e) {
            SqlCommandBuilder authorsCommandBuilder = new SqlCommandBuilder(_authorsAdapter);
            _authorsAdapter.Update(_biblioDS, "Authors");
            this.Close();
        }

        private void btnCancel_click(object sender, EventArgs e) {
            bindingSourceAuthors.CancelEdit();
            SetNavigationUI();
        }

        private void btnSave_click(object sender, EventArgs e) {
            bindingSourceAuthors.EndEdit();
            SetNavigationUI();
        }

        private void SetNavigationUI() {
            txtAuID.ReadOnly = true;
            txtAuthorName.ReadOnly = true;
            txtYearBorn.ReadOnly = true;
            btnNew.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnClose.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void SetAddNewUI() {
            txtAuID.ReadOnly = false;
            txtAuthorName.ReadOnly = false;
            txtYearBorn.ReadOnly = false;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void SetEditUI() {
            txtAuID.ReadOnly = true;
            txtAuthorName.ReadOnly = false;
            txtYearBorn.ReadOnly = false;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
    }
}