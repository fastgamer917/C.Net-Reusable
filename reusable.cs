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
   