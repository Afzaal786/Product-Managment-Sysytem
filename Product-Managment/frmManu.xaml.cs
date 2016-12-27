using System;
using PMSDataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Product_Managment
{
    /// <summary>
    /// Interaction logic for frmManu.xaml
    /// </summary>
    public partial class frmManu : Window
    {
    MANU tobjAuthor = new MANU();
    authorFactory objAuthorFactory = new authorFactory();

    public frmManu()
    {
        InitializeComponent();
    }

    private void btnAutClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void btnAutSave_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int result;
            if (string.IsNullOrEmpty(txtAutName.Text) || string.IsNullOrWhiteSpace(txtAutName.Text))
            {
                MessageBox.Show("Please enter a valid author name.", "Error");
            }
            else
            {
                if (int.TryParse(txtAutName.Text, out result))
                    MessageBox.Show("Name cant be a number.", "Error");
                else
                {
                    tobjAuthor.authorName = txtAutName.Text;
                    if (!string.IsNullOrEmpty(txtAutContact.Text))
                        tobjAuthor.authorContact = txtAutContact.Text;
                    if (objAuthorFactory.insert(tobjAuthor))
                    {
                        MessageBox.Show("Record saved successfully!", "Success");
                        txtAutName.Clear();
                        txtAutContact.Clear();
                    }
                    else
                        MessageBox.Show("Record Cant be saved.", "Error");
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            txtAutName.Clear();
            txtAutContact.Clear();
        }

    }

    private void btnViewAllAuthors_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            List<MANU> authorList = objAuthorFactory.getAllAuthors();
            dgAuthor.ItemsSource = authorList;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }

    private void btnAuthorSearch_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int resultId;
            if (!string.IsNullOrEmpty(txtSearchAuthor.Text))
            {
                bool successfullyParsed = int.TryParse(txtSearchAuthor.Text, out resultId);
                if (successfullyParsed)
                {
                    var result = objAuthorFactory.getAllAuthorsById(resultId);
                    if (result.Count() != 0)
                    {
                        dgAuthor.ItemsSource = result;
                        txtSearchAuthor.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found with given Id", "Error");
                        txtSearchAuthor.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchAuthor.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.", "Error");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnAuthorDelete_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objAuthorFactory.delete(resultId))
                    {
                        MessageBox.Show("Record Deleted Successfully.", "Success");
                        txtGiveId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record exist with given Id", "Error");
                        txtGiveId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtGiveId.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.", "Error");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnAuthorUpdate_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int resultId, resultName;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (!string.IsNullOrEmpty(txtGiveName.Text))
                    {
                        if (!int.TryParse(txtGiveName.Text, out resultName))
                        {
                            if (objAuthorFactory.update(resultId, txtGiveName.Text, txtGiveContact.Text))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                            }
                            else
                            {
                                MessageBox.Show("No record exist with given Id.", "Error");
                                txtGiveId.Clear();
                            }
                        }
                        else
                            MessageBox.Show("Name cant be number.", "Error");
                    }
                    else
                        MessageBox.Show("Please enter the name.", "Error");
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchAuthor.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.", "Error");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnClearAuthorGrid_Click(object sender, RoutedEventArgs e)
    {

    }
}
}
