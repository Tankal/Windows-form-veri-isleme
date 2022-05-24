namespace EnmosStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                for (int i = 0; i < 9; i++)
                {

                    for (int j = 0; j < 23; j++)
                    {

                        DateTime bsl = DateTime.ParseExact(dizidur[j, 1], "yyyy,M,d,H,m,s", null);
                        DateTime bts = DateTime.ParseExact(dizidur[j, 2], "yyyy,M,d,H,m,s", null);


                        if (bsl > DateTime.ParseExact(diziis[i, 1], "yyyy,M,d,H,m,s", null))
                        {

                            if (bts < DateTime.ParseExact(diziis[i, 2], "yyyy,M,d,H,m,s", null))
                            {
                                TimeSpan sonuc = (bts - bsl);
                                int a = (int)sonuc.TotalMinutes;
                                if (dizidur[j, 0] == "Araba Yok")
                                {
                                    dizisonuc[i, 1] = dizisonuc[i, 1] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 1] = dizisonuc[9, 1] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;

                                }
                                else if (dizidur[j, 0] == "Arýza")
                                {
                                    dizisonuc[i, 2] = dizisonuc[i, 2] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 2] = dizisonuc[9, 2] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;


                                }
                                else if (dizidur[j, 0] == "Mal Yok")
                                {
                                    dizisonuc[i, 3] = dizisonuc[i, 3] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 3] = dizisonuc[9, 3] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;

                                }
                                else if (dizidur[j, 0] == "Enerji Kesildi")
                                {
                                    dizisonuc[i, 4] = dizisonuc[i, 4] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 4] = dizisonuc[9, 4] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;


                                }
                            }
                            else if (bsl < DateTime.ParseExact(diziis[i, 2], "yyyy,M,d,H,m,s", null))
                            {
                                DateTime b = (DateTime.ParseExact(diziis[i, 2], "yyyy,M,d,H,m,s", null));

                                TimeSpan kalan = b - bsl;
                                int a = (int)kalan.TotalMinutes;
                                if (dizidur[j, 0] == "Araba Yok")
                                {
                                    dizisonuc[i, 1] = dizisonuc[i, 1] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 1] = dizisonuc[9, 1] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;


                                }
                                else if (dizidur[j, 0] == "Arýza")
                                {
                                    dizisonuc[i, 2] = dizisonuc[i, 2] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 2] = dizisonuc[9, 2] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;


                                }
                                else if (dizidur[j, 0] == "Mal Yok")
                                {
                                    dizisonuc[i, 3] = dizisonuc[i, 3] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 3] = dizisonuc[9, 3] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;

                                }
                                else if (dizidur[j, 0] == "Enerji Kesildi")
                                {
                                    dizisonuc[i, 4] = dizisonuc[i, 4] + a;
                                    dizisonuc[i, 5] = dizisonuc[i, 5] + a;
                                    dizisonuc[9, 4] = dizisonuc[9, 4] + a;
                                    dizisonuc[9, 5] = dizisonuc[9, 5] + a;

                                }

                                TimeSpan artan = bts - b;
                                int c = (int)artan.TotalMinutes;
                                if (c > 480)
                                {
                                    if (dizidur[j, 0] == "Araba Yok")
                                    {
                                        dizisonuc[(i + 1), 1] = dizisonuc[(i + 1), 1] + 480;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + 480;
                                        dizisonuc[9, 1] = dizisonuc[9, 1] + 480;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + 480;



                                    }
                                    else if (dizidur[j, 0] == "Arýza")
                                    {
                                        dizisonuc[(i + 1), 2] = dizisonuc[(i + 1), 2] + 480;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + 480;
                                        dizisonuc[9, 2] = dizisonuc[9, 2] + 480;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + 480;


                                    }
                                    else if (dizidur[j, 0] == "Mal Yok")
                                    {
                                        dizisonuc[(i + 1), 3] = dizisonuc[(i + 1), 3] + 480;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + 480;
                                        dizisonuc[9, 3] = dizisonuc[9, 3] + 480;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + 480;


                                    }
                                    else if (dizidur[j, 0] == "Enerji Kesildi")
                                    {
                                        dizisonuc[(i + 1), 4] = dizisonuc[(i + 1), 4] + 480;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + 480;
                                        dizisonuc[9, 4] = dizisonuc[9, 4] + 480;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + 480;

                                    }
                                    int d = c - 480;
                                    if (dizidur[j, 0] == "Araba Yok")
                                    {
                                        dizisonuc[(i + 2), 1] = dizisonuc[(i + 2), 1] + d;
                                        dizisonuc[(i + 2), 5] = dizisonuc[(i + 2), 5] + d;
                                        dizisonuc[9, 1] = dizisonuc[9, 1] + d;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + d;



                                    }
                                    else if (dizidur[j, 0] == "Arýza")
                                    {
                                        dizisonuc[(i + 2), 2] = dizisonuc[(i + 2), 2] + d;
                                        dizisonuc[(i + 2), 5] = dizisonuc[(i + 2), 5] + d;
                                        dizisonuc[9, 2] = dizisonuc[9, 2] + d;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + d;


                                    }
                                    else if (dizidur[j, 0] == "Mal Yok")
                                    {
                                        dizisonuc[(i + 2), 3] = dizisonuc[(i + 2), 3] + d;
                                        dizisonuc[(i + 2), 5] = dizisonuc[(i + 2), 5] + d;
                                        dizisonuc[9, 3] = dizisonuc[9, 3] + d;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + d;


                                    }
                                    else if (dizidur[j, 0] == "Enerji Kesildi")
                                    {
                                        dizisonuc[(i + 2), 4] = dizisonuc[(i + 2), 4] + d;
                                        dizisonuc[(i + 2), 5] = dizisonuc[(i + 2), 5] + d;
                                        dizisonuc[9, 4] = dizisonuc[9, 4] + d;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + d;


                                    }

                                }
                                else if (c < 480)
                                {
                                    if (dizidur[j, 0] == "Araba Yok")
                                    {
                                        dizisonuc[(i + 1), 1] = dizisonuc[(i + 1), 1] + c;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + c;
                                        dizisonuc[9, 1] = dizisonuc[9, 1] + c;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + c;



                                    }
                                    else if (dizidur[j, 0] == "Arýza")
                                    {
                                        dizisonuc[(i + 1), 2] = dizisonuc[(i + 1), 2] + c;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + c;
                                        dizisonuc[9, 2] = dizisonuc[9, 2] + c;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + c;


                                    }
                                    else if (dizidur[j, 0] == "Mal Yok")
                                    {
                                        dizisonuc[(i + 1), 3] = dizisonuc[(i + 1), 3] + c;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + c;
                                        dizisonuc[9, 3] = dizisonuc[9, 3] + c;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + c;


                                    }
                                    else if (dizidur[j, 0] == "Enerji Kesildi")
                                    {
                                        dizisonuc[(i + 1), 4] = dizisonuc[(i + 1), 4] + c;
                                        dizisonuc[(i + 1), 5] = dizisonuc[(i + 1), 5] + c;
                                        dizisonuc[9, 4] = dizisonuc[9, 4] + c;
                                        dizisonuc[9, 5] = dizisonuc[9, 5] + c;


                                    }
                                }
                            }
                        }
                    }


            }
            listView1.Columns.Add("Ýþ Emir Numarasý",150);
            listView1.Columns.Add("Araba Yok",100);
            listView1.Columns.Add("Arýza",100);
            listView1.Columns.Add("Mal Yok",100);
            listView1.Columns.Add("Enerji Kesildi",100);
            listView1.Columns.Add("Toplam",100x"");

            for (int i = 0; i < 9; i++)
            {

                string[] arr = new string[6];
                ListViewItem itm;

                string aa = Convert.ToString(dizisonuc[i, 0]);
                string bb = Convert.ToString(dizisonuc[i, 1]);
                string cc = Convert.ToString(dizisonuc[i, 2]);
                string dd = Convert.ToString(dizisonuc[i, 3]);
                string ee = Convert.ToString(dizisonuc[i, 4]);
                string ff = Convert.ToString(dizisonuc[i, 5]);

                arr[0] = aa;
                arr[1] = bb;
                arr[2] = cc;
                arr[3] = dd;
                arr[4] = ee;
                arr[5] = ff;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            string[] arr2 = new string[6];
            ListViewItem item;

            
            string bbb = Convert.ToString(dizisonuc[9, 1]);
            string ccc = Convert.ToString(dizisonuc[9, 2]);
            string ddd = Convert.ToString(dizisonuc[9, 3]);
            string ege = Convert.ToString(dizisonuc[9, 4]);
            string fff = Convert.ToString(dizisonuc[9, 5]);

            arr2[0] = "Toplam";
            arr2[1] = bbb;
            arr2[2] = ccc;
            arr2[3] = ddd;
            arr2[4] = ege;
            arr2[5] = fff;
            item = new ListViewItem(arr2);
            listView1.Items.Add(item);

        }




        string[,] diziis = new string[9, 3] { { "1001", "2016,1,1,8,0,0","2016,1,1,16,0,0" }, { "1002", "2016,1,1,16,0,0", "2016,1,2,0,0,0" },
            { "1003", "2016,1,2,0,0,0", "2016,1,2,8,0,0" }, { "1004", "2016,1,2,8,0,0", "2016,1,2,16,0,0" },
            { "1005", "2016,1,2,16,0,0", "2016,1,3,0,0,0" }, { "1006", "2016,1,3,0,0,0", "2016,1,3,8,0,0" },
            { "1007", "2016,1,3,8,0,0", "2016,1,3,16,0,0" },{ "1008", "2016,1,3,16,0,0","2016,1,4,0,0,0" },{ "1009", "2016,1,4,0,0,0","2016,1,4,16,0,0" } };

            string[,] dizidur = new string[23, 3] { { "Araba Yok", "2016,1,1,10,0,0","2016,1,1,10,10,0" }, { "Arýza", "2016,1,1,10,30,0", "2016,1,1,11,0,0" },
            { "Araba Yok", "2016,1,1,12,0,0", "2016,1,1,12,30,0" }, { "Araba Yok", "2016,1,1,14,0,0", "2016,1,1,14,10,0" },
            { "Mal Yok", "2016,1,1,15,0,0", "2016,1,1,16,30,0" }, { "Araba Yok", "2016,1,1,18,0,0", "2016,1,1,18,10,0" },
            { "Araba Yok", "2016,1,1,20,0,0", "2016,1,1,20,30,0" },{ "Araba Yok", "2016,1,1,22,0,0","2016,1,1,22,10,0" },
            { "Enerji Kesildi", "2016,1,1,23,0,0", "2016,1,2,8,30,0" },{"Araba Yok", "2016,1,2,10,0,0","2016,1,2,10,10,0" },
            { "Araba Yok", "2016,1,2,12,0,0", "2016,1,2,12,30,0" },{"Arýza", "2016,1,2,13,0,0", "2016,1,2,13,45,0" },
            { "Araba Yok", "2016,1,2,14,0,0", "2016,1,2,14,10,0" },{"Araba Yok", "2016,1,2,18,0,0", "2016,1,2,18,10,0" },
            { "Enerji Kesildi", "2016,1,2,20,0,0", "2016,1,3,2,10,0" },{"Araba Yok", "2016,1,3,4,0,0", "2016,1,3,4,30,0" },
            { "Mal Yok", "2016,1,3,6,0,0", "2016,1,3,9,30,0" },{"Araba Yok", "2016,1,3,10,0,0","2016,1,3,10,10,0" },
            { "Araba Yok", "2016,1,3,12,0,0", "2016,1,3,12,30,0" },{"Araba Yok", "2016,1,3,14,0,0", "2016,1,3,14,10,0" },
            { "Arýza", "2016,1,3,15,0,0", "2016,1,3,18,45,0" }, {"Araba Yok", "2016,1,3,20,0,0", "2016,1,3,20,30,0" },
            { "Araba Yok", "2016,1,3,22,0,0", "2016,1,3,22,10,0" }};

        int[,] dizisonuc = { { 1001, 0, 0, 0, 0, 0 }, { 1002, 0, 0, 0, 0, 0 }, { 1003, 0, 0, 0, 0, 0 }, { 1004, 0, 0, 0, 0, 0 }, { 1005, 0, 0, 0, 0, 0 }, { 1006, 0, 0, 0, 0, 0 }, { 1007, 0, 0, 0, 0, 0 }, { 1008, 0, 0, 0, 0, 0 }, { 1009, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };


    }
    }

