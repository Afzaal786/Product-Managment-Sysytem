using System;
using PMSDataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Product_Managment
{
    /// <summary>
    /// Interaction logic for frmPublisher.xaml
    /// </summary>
    public partial class frmPublisher : Window
    {
        PPUBLISHER tobjPublisher = new PPUBLISHER();
        publisherFactory objPublisherFactory = new publisherFactory();
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPublisherSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int result;
                if (string.IsNullOrEmpty(txtPubName.Text) || string.IsNullOrWhiteSpace(txtPubName.Text))
                {
                    MessageBox.Show("Please Enter a valid publisher name.", "Error");
                }
                else
                {
                    if (int.TryParse(txtPubName.Text, out result))
                        MessageBox.Show("Name cant be a number.", "Error");
                    else
                    {
                        tobjPublisher.publisherName = txtPubName.Text;
                        if (!string.IsNullOrEmpty(txtPubContact.Text))
                            tobjPublisher.publisherContact = txtPubContact.Text;
                        if (objPublisherFactory.insert(tobjPublisher))
                        {
                            MessageBox.Show("Record saved successfully!", "Success");
                            txtPubName.Clear();
                            txtPubContact.Clear();
                        }
                        else
                            MessageBox.Show("Record Cant be saved.", "Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPubName.Clear();
                txtPubContact.Clear();
            }

        }

        private void btnViewAllPublishers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<PPUBLISHER> publisherList = objPublisherFactory.getAllPublishers();
                dgPublisher.ItemsSource = publisherList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnPublisherSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchPublisher.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchPublisher.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objPublisherFactory.getAllPublishersById(resultId);
                        if (result.Count() != 0)
                        {
                            dgPublisher.ItemsSource = result;
                            txtSearchPublisher.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchPublisher.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchPublisher.Clear();
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

        private void btnPublisherDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtGiveId.Text))
                {
                    bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                    if (successfullyParsed)
                    {
                        if (objPublisherFactory.delete(resultId))
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
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnPublisherUpdate_Click(object sender, RoutedEventArgs e)
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
                                if (objPublisherFactory.update(resultId, txtGiveName.Text, txtGiveContact.Text))
                                {
                                    MessageBox.Show("Updated Successfully", "Success");
                                    txtGiveId.Clear();
                                    txtGiveContact.Clear();
                                    txtGiveName.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("No record exist with given Id.", "Error");
                                    txtGiveId.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Name cant be a number.", "Error");
                                txtGiveName.Clear();
                            }
                        }
                        else
                            MessageBox.Show("Please enter the name.", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchPublisher.Clear();
                    }
                }
                else
                    MessageBox.Show("Please enter the Id first.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


    }
}
