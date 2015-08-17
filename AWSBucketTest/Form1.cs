namespace AWSBucketTest
{
    using System;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;

    using Amazon.S3;
    using Amazon.S3.Model;

    using Newtonsoft.Json;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new AmazonS3Config
                {
                    RegionEndpoint = Amazon.RegionEndpoint.APSoutheast2
                };

                if (this.checkBoxUseProxy.Checked)
                {
                    var proxy = new WebProxy(this.textBoxProxy.Text, int.Parse(this.textBoxProxyPort.Text)) { BypassList = new string[] { textBoxProxyBypass.Text } };
                    WebRequest.DefaultWebProxy = proxy;
                }

                AmazonS3Client amazonS3Client = null;
                if (this.checkBoxUseKeySecret.Checked && this.checkBoxUseToken.Checked == false)
                {
                    amazonS3Client = new AmazonS3Client(this.textBoxKey.Text, this.textBoxSecret.Text, config);
                }
                else if (this.checkBoxUseKeySecret.Checked && this.checkBoxUseToken.Checked)
                {
                    amazonS3Client = new AmazonS3Client(this.textBoxKey.Text, this.textBoxSecret.Text, this.textBoxToken.Text, config);
                }
                else
                {
                    amazonS3Client = new AmazonS3Client(config);
                }

                //textBoxOutput.Text = JsonConvert.SerializeObject(amazonS3Client.Config);

                var request = new GetObjectRequest
                {
                    BucketName = this.textBoxBucket.Text,
                    Key = this.textBoxFile.Text
                };

                using (GetObjectResponse response = amazonS3Client.GetObject(request))
                {
                    using (var reader = new StreamReader(response.ResponseStream))
                    {
                        this.textBoxOutput.Text = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                this.textBoxOutput.Text = ex.ToString();
            }
        }
    }
}