Invode permission for cross-thread:-
   if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate {textBox1.Text= con; }));
            }
            else
            {
                textBox1.Text = con;
            }
           
 
 System.Net.Http   HttpClient Class
 public  async void senderm()
        {
            Thread.Sleep(10000);
            HttpClient client = new HttpClient();
            HttpResponseMessage content = await client.GetAsync("https://www.google.com");
            string con =await  content.Content.ReadAsStringAsync();
         }
 //Using Task to not freez UI thread.  
        public async void callfunc()
        {
            await Task.Run(() => getcap(apikey.Text, sitekey.Text, siteurl.Text));
        }
        public void getcap(string apikey, string googlekey,string siteurl)
        {
            var APIKey = apikey;
            var googleKey = googlekey;
            var pageUrl = siteurl;
           //all other code;
        }

Accessing WinForms on another threads:-
   Class Form1:-
   private void button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1(this);


           // Task.Run(()=>Class1.runcode());
        }
Class Class1:-
   public  Class1(Form1 form) //constructor receiving current instance of form.
        {
            Task.Run(() => runcode(form));
        }
        public static async void runcode(Form1 form)
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.google.com");
            Console.WriteLine(response);
            if(form.textBox1.InvokeRequired)
            {
                form.textBox1.Invoke(new MethodInvoker(delegate { form.textBox1.Text = response; }));
            }
            else
            form.textBox1.Text = "hello working";
            
           
        }

creating new instance of Form1 and the updating textbox wont help because completely new instace is created and wont update existing textbox.
