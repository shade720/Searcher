using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searcher.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectKeywordsFileButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                KeywordFilepathTextbox.Text = OpenFileDialog.FileName;
            }
        }

        private void SelectCatalogButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() != DialogResult.OK) return;
            CatalogPathTextbox.Text = FolderBrowser.SelectedPath;
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CatalogPathTextbox.Text) || string.IsNullOrEmpty(KeywordFilepathTextbox.Text)) return;
            pictureBox1.Visible = true;
            try
            {
                var searchResult = await Task.Run(() => Models.Searcher.SearchKeywordsInDirectory(CatalogPathTextbox.Text, KeywordFilepathTextbox.Text, CaseSensitiveCheckBox.Checked));
                ShowResults(searchResult);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace);
            }
            pictureBox1.Visible = false;
        }

        private void ShowResults(Models.SearchResult searchResult)
        {
            KeywordFoundByFilesListView.Items.Clear();
            KeywordFoundByFilesListView.Groups.Clear();
            foreach (var resultByFile in searchResult.KeywordsFoundByFiles)
            {
                KeywordFoundByFilesListView.Groups.Add(new ListViewGroup(resultByFile.Filename, resultByFile.Filename));
                foreach (var keywordOccurrences in resultByFile.KeywordsOccurrences)
                {
                    var item = new ListViewItem(keywordOccurrences.Key, KeywordFoundByFilesListView.Groups[resultByFile.Filename]);
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, keywordOccurrences.Value.ToString()));
                    KeywordFoundByFilesListView.Items.Add(item);
                }
            }

            KeywordFoundedOverallListView.Items.Clear();
            KeywordFoundedOverallListView.Groups.Clear();
            foreach (var keywordOccurrences in searchResult.KeywordsFoundOverall)
            {
                var item = new ListViewItem(keywordOccurrences.Key);
                item.SubItems.Add(keywordOccurrences.Value.ToString());
                KeywordFoundedOverallListView.Items.Add(item);
            }
        }
    }
}
