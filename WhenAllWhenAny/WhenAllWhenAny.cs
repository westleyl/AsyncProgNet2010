using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhenAllWhenAny
{
    public partial class WhenAllWhenAny : Form
    {     
        public WhenAllWhenAny()
        {
            InitializeComponent();
        }

        private void btnGetMetadata_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;
            GetMetaDataAsync(txtArtistName.Text, txtAlbumName.Text);
        }

        private async void GetMetaDataAsync(string artistName, string albumName)
        {
            try
            {

                var imdb = GetImdbLabelNameAsync(artistName, albumName);
                var gracenote = GetGraceNoteLabelNameAsync(artistName, albumName);
                var freedb = GetFreeDbLabelNameAsync(artistName, albumName);
                var allTasks = new List<Task<String>> {imdb, gracenote, freedb};

                if (chkFastestWins.Checked)
                {                    
                    while (!allTasks.Any(t => t.IsCompleted && !t.IsFaulted))
                    {
                        try
                        {
                            await
                                Task.WhenAny(allTasks.Except(
                                allTasks.Where(t => t.IsFaulted)));
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    try
                    {
                        await
                            Task.WhenAll(allTasks);
                    }
                    catch (Exception)
                    {
                    }
                }

                var onlySuccessful = allTasks.ToList().Where(t => !t.IsFaulted);

                string results = string.Empty;
                if ((imdb.IsCompleted) && (!imdb.IsFaulted))
                {
                    results += "IMDB : " + imdb.Result + "\r\n";
                }
                if ((gracenote.IsCompleted) && (!gracenote.IsFaulted))
                {
                    results += "GraceNote : " + gracenote.Result + "\r\n";
                }
                if ((freedb.IsCompleted) && (!freedb.IsFaulted))
                {
                    results += "FreeDb : " + freedb.Result + "\r\n";
                }

                txtResults.Text += results;
            }
            catch (AggregateException ex)
            {
                // WhenAny
                txtResults.Text += ex.InnerException.Message + "\r\n" + ex.GetType().ToString();
            }
            catch (Exception ex)
            {
                // WhenAll
                txtResults.Text += ex.GetType().ToString() + "\r\n" + ex.Message;
            }
        }

        private async Task<string> GetGraceNoteLabelNameAsync(string artist, 
            string albumName)
        {
            await
            Task.Delay(500);
            throw new WebException("Gracenote web timeout");
            return "Island Records";
        }

        private async Task<string> GetImdbLabelNameAsync(string artist, 
            string albumName)
        {
            await
            Task.Delay(2000);
            throw new WebException("Gracenote web timeout");
            // would be some web service somewhere
            await Task.Delay(2000);
            return "Island Records";
        }

        private async Task<string> GetFreeDbLabelNameAsync(string artist, 
            string albumName)
        {
            // would be some web service somewhere
            await Task.Delay(5000);
            return "Mercury Records Ltd";
        }
    }

    #region Exception handling snippet 1
    
    //// would be some web service somewhere
    //await
    //Task.Delay(500);
    //throw new WebException("Gracenote web timeout");
    //return "Island Records";
    
    #endregion

    #region Exception handling snippet 2

    //    catch (Exception ex)
    //    {
    //        txtResults.Text += ex.Message + "\r\n" + ex.GetType().ToString();
    //    }

    #endregion

    #region Exception handling snippet 3

    //    catch (AggregateException ex)
    //    {
    //        // WhenAny
    //        txtResults.Text += ex.InnerException.Message + "\r\n" + ex.GetType().ToString();
    //    }
    //    catch (Exception ex)
    //    {
    //        // WhenAll
    //        txtResults.Text += ex.GetType().ToString() + "\r\n" + ex.Message;
    //    }

    #endregion

    #region Exception handling snippet 4

    //try
    //{
    //    // would be some web service somewhere
    //    await
    //    Task.Delay(500);
    //    throw new WebException("Web timeout");
    //    return "Island Records";
    //}
    //catch (Exception ex)
    //{
    //    return "Exception - " + ex.Message + " (" + ex.GetType().ToString() + ")";
    //}
   
    #endregion

    #region Entire Exception handling method

    //    private async void GetMetaDataAsync(string artistName, string albumName)
    //{
    //    try
    //    {
    //        var imdb = GetImdbLabelNameAsync(artistName, albumName);
    //        var gracenote = GetGraceNoteLabelNameAsync(artistName, albumName);
    //        var freedb = GetFreeDbLabelNameAsync(artistName, albumName);

    //        if (chkFastestWins.Checked)
    //        {
    //            await Task.WhenAny(imdb, gracenote, freedb);
    //        }
    //        else
    //        {
    //            await Task.WhenAll(imdb, gracenote, freedb);
    //        }

    //        string results = string.Empty;
    //        if (imdb.IsCompleted)
    //        {
    //            results += "IMDB : " + imdb.Result + "\r\n";
    //        }
    //        if (gracenote.IsCompleted)
    //        {
    //            results += "GraceNote : " + gracenote.Result + "\r\n";
    //        }
    //        if (freedb.IsCompleted)
    //        {
    //            results += "FreeDb : " + freedb.Result + "\r\n";
    //        }

    //        txtResults.Text += results;
    //    }
    //    catch (AggregateException ex)
    //    {
    //        // WhenAny
    //        txtResults.Text += ex.GetType().ToString() + "\r\n" + ex.InnerException.GetType().ToString() + "\r\n" + ex.InnerException.Message;
    //    }
    //    catch (Exception ex)
    //    {
    //        // WhenAll
    //        txtResults.Text += ex.GetType().ToString() + "\r\n" + ex.Message;
    //    }
    //}

    #endregion
}

