using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Tensors
{   
    public class MyForm : Form
    {
        
        public MyForm()
        {

            LogForm.a = "        Your log:";
            


            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var answerText = new Label()
            {
                Location = new Point(10, 10),
                Size = new Size(50, 50),
                Text = "azakaza",

            };

            string act = "";

            Size textboxSize = new Size(40, 30);
            int x = 0;   //10
            int y = -10; //0
            var panel1 = new Panel()
            {
                Location = new Point(50, 30),
                Size = new Size(textboxSize.Width * 3 + x*2, textboxSize.Height * 3 + y*2),
            };

            var panel2 = new Panel()
            {
                Location = new Point(panel1.Location.X + 300, panel1.Location.Y),
                Size = new Size(textboxSize.Width * 3 + x * 2, textboxSize.Height * 3 + y * 2),
            };

            var answPanel = new Panel()
            {
                Location = new Point(panel2.Location.X + 190, panel1.Location.Y),
                Size = new Size(textboxSize.Width * 3 + x * 2, textboxSize.Height * 3 + y * 2),
            };

            var arraytextbox = new TextBox[3, 3];
            #region//arraytextbox
            arraytextbox[0, 0] = new TextBox()
            {
                Location = new Point(0, 0),
                Size = textboxSize
            };
            arraytextbox[1, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, 0),
                Size = textboxSize
            };
            arraytextbox[2, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, 0),
                Size = textboxSize
            };

            arraytextbox[0, 1] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height + y),
                Size = textboxSize
            };
            arraytextbox[1, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height + y),
                Size = textboxSize
            };
            arraytextbox[2, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height + y),
                Size = textboxSize
            };

            arraytextbox[0, 2] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height*2 + y*2),
                Size = textboxSize
            };
            arraytextbox[1, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height*2 + y*2),
                Size = textboxSize
            };
            arraytextbox[2, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height*2 + y*2),
                Size = textboxSize
            };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    panel1.Controls.Add(arraytextbox[i,j]);
                }
            }

            #endregion

            var arraytextbox1 = new TextBox[3, 3];
            #region//arraytextbox
            arraytextbox1[0, 0] = new TextBox()
            {
                Location = new Point(0, 0),
                Size = textboxSize
            };
            arraytextbox1[1, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, 0),
                Size = textboxSize
            };
            arraytextbox1[2, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, 0),
                Size = textboxSize
            };

            arraytextbox1[0, 1] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height + y),
                Size = textboxSize
            };
            arraytextbox1[1, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height + y),
                Size = textboxSize
            };
            arraytextbox1[2, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height + y),
                Size = textboxSize
            };

            arraytextbox1[0, 2] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };
            arraytextbox1[1, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };
            arraytextbox1[2, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    panel2.Controls.Add(arraytextbox1[i, j]);
                }
            }

            #endregion

            var answTextbox = new TextBox[3, 3];
            #region//answTextBox
            answTextbox[0, 0] = new TextBox()
            {
                Location = new Point(0, 0),
                Size = textboxSize
            };
            answTextbox[1, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, 0),
                Size = textboxSize
            };
            answTextbox[2, 0] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, 0),
                Size = textboxSize
            };

            answTextbox[0, 1] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height + y),
                Size = textboxSize
            };
            answTextbox[1, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height + y),
                Size = textboxSize
            };
            answTextbox[2, 1] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height + y),
                Size = textboxSize
            };

            answTextbox[0, 2] = new TextBox()
            {
                Location = new Point(0, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };
            answTextbox[1, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width + x, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };
            answTextbox[2, 2] = new TextBox()
            {
                Location = new Point(textboxSize.Width * 2 + 2 * x, textboxSize.Height * 2 + y * 2),
                Size = textboxSize
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    answPanel.Controls.Add(answTextbox[i, j]);
                }
            }

            #endregion

            


            var element1 = new ComboBox()
            {
                Location = new Point(panel1.Location.X, panel1.Location.Y + textboxSize.Height * 3),
                Size = new Size(textboxSize.Width*3, 40),
                Items = {"vector", "tensor"},
                SelectedIndex = 1,
            };

            var actCombobox = new ComboBox()
            {
                Location = new Point(panel1.Location.X + 150, panel1.Location.Y + panel1.Size.Height / 3),
                Size = new Size(textboxSize.Width * 3, 40),
                Items = { "*", "×", "⊗", "**", "*×", "×*", "××", "tr" },
                SelectedIndex = 0,
                Font = new Font("",12),
            };
            
            var element2 = new ComboBox()
            {
                Location = new Point(panel2.Location.X, panel2.Location.Y + textboxSize.Height * 3),
                Size = new Size(textboxSize.Width * 3, 40),
                Items = { "vector", "tensor" },
                SelectedIndex = 1,
            };

            var button = new Button()
            {
                Location =new Point(element1.Location.X, element1.Location.Y+60),
                Size = new Size(420,40),
                Text = "Calculate",
            };

            var eraseButton = new Button()
            {
                Location = new Point(button.Location.X+150, button.Location.Y+50 ),
                Size = new Size(120, 40),
                Text = "Erase",
            };

            var copyButton = new Button()
            {
                Location = new Point(eraseButton.Location.X + 150, eraseButton.Location.Y),
                Size = new Size(120, 40),
                Text = "Copy to 1st",
            };

            var equalLabel = new Label()
            {
                Location = new Point(actCombobox.Location.X + 290, actCombobox.Location.Y-10),
                Size = new Size(30, 30),
                Font = new Font("Arial",20),
                Text = "=",
            };

            var label = new Label()
            {
                Location = new Point(actCombobox.Location.X+5, actCombobox.Location.Y + 30),
                Size = new Size(actCombobox.Size.Width, actCombobox.Size.Height +20),
                Text = "It can't multiply 2 tensors =(",
                Visible = false,
                
            };


            var tipText = new Label()
            {
                Location = new Point(copyButton.Location.X + 160, copyButton.Location.Y - 100),
                Size = new Size(120, 300),
                Text = "Tip for you:" + "\n" + "\n" +
                 "vector = ( i, j, k )" + "\n" + "\n" +
                 "             | ii,  ij,  ik  |" + "\n" +
                 "tensor =| ji,  jj,  jk  |" + "\n" +
                 "             | ki, kj, kk |",
                Font = new Font("Arial",10),
            };

            


            var logbutton = new Button()
            {
                Location = new Point(button.Location.X, button.Location.Y+50),
                Size = new Size(120,40),
                Text = "Show log",

            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    answTextbox[i, j].Enabled = false;
                }
            }
           

            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(element1);
            Controls.Add(actCombobox);
            Controls.Add(element2);
            Controls.Add(label);

            Controls.Add(button);
            Controls.Add(eraseButton);
            Controls.Add(copyButton);
            Controls.Add(equalLabel);
            Controls.Add(answPanel);

            Controls.Add(logbutton);
            Controls.Add(tipText);

            element1.SelectedIndexChanged += ChangePanel1;
            element2.SelectedIndexChanged += ChangePanel2;
            actCombobox.SelectedIndexChanged += ChangeAct;
            button.Click += Calculate;
            eraseButton.Click += Erase;
            copyButton.Click += Copy;
            logbutton.Click += ShowLog;

            void ChangePanel1(object sender, EventArgs e)
            {
                ComboBox a = (ComboBox)sender;
                ChangePanel(a, arraytextbox);
            }
            void ChangePanel2(object sender, EventArgs e)
            {
                ComboBox a = (ComboBox)sender;
                ChangePanel(a, arraytextbox1);
            }
            void ChangeAct(object sender, EventArgs e)
            {
                
                ComboBox a = (ComboBox)sender;
                act = (string)a.SelectedItem;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arraytextbox[i, j].Enabled = true;
                        arraytextbox1[i, j].Enabled = true;
                    }
                }
                element1.Enabled = true;
                element2.Enabled = true;
                element1.SelectedIndex = 1;
                element2.SelectedIndex = 1;

                if ((string)a.SelectedItem == "tr")
                {
                    element1.SelectedIndex = 1;
                    element1.Enabled = false;
                    element2.SelectedIndex = 1;
                    element2.Enabled = false;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            arraytextbox[i, j].Text = "";
                            arraytextbox[i, j].Enabled = false;
                        }
                    }

                }
                else if((string)a.SelectedItem == "⊗")
                {
                    element1.SelectedIndex = 0;
                    element1.Enabled = false;
                    element2.SelectedIndex = 0;
                    element2.Enabled = false;

                }
                else if ((string)a.SelectedItem == "×")
                {
                    if (arraytextbox[1,1].Enabled)
                    {

                    }

                    label.Visible = true;


                }
                else if ( ((string)a.SelectedItem == "**") ||
                          ((string)a.SelectedItem == "*×") ||
                          ((string)a.SelectedItem == "×*") ||
                          ((string)a.SelectedItem == "××") )
                {
                    element1.SelectedIndex = 1;
                    element1.Enabled = false;
                    element2.SelectedIndex = 1;
                    element2.Enabled = false;

                }

                if (((string)a.SelectedItem != "×")&&(label.Visible))
                {
                    label.Visible = false;
                }
                

                
            }


            void ShowLog(object sender, EventArgs e)
            {
                var log = new LogForm();
                log.Width = 400;
                log.Height = 500;
                log.FormBorderStyle = FormBorderStyle.FixedDialog;
                log.MaximizeBox = false;
                log.Show();

            }

       
            void Calculate(object sender, EventArgs e)
            {
                //object first = new object();
                //object second = new object();

                

                bool vect1 = false;
                bool vect2 = false;

                var a = new vector();
                var b = new vector();
                var A = new tensor();
                var B = new tensor();
                
                try
                {
                    if (((string)actCombobox.SelectedItem != "tr"))
                    {
                        if ((string)element1.SelectedItem == "vector")
                        {
                            //first = new vector();
                            a.i = Convert.ToInt32(arraytextbox[0, 1].Text);
                            a.j = Convert.ToInt32(arraytextbox[1, 1].Text);
                            a.k = Convert.ToInt32(arraytextbox[2, 1].Text);
                            //first = a;
                            vect1 = true;
                        }
                        else
                        {
                            //first = new tensor();
                            A.ii = Convert.ToInt32(arraytextbox[0, 0].Text);
                            A.ij = Convert.ToInt32(arraytextbox[1, 0].Text);
                            A.ik = Convert.ToInt32(arraytextbox[2, 0].Text);

                            A.ji = Convert.ToInt32(arraytextbox[0, 1].Text);
                            A.jj = Convert.ToInt32(arraytextbox[1, 1].Text);
                            A.jk = Convert.ToInt32(arraytextbox[2, 1].Text);

                            A.ki = Convert.ToInt32(arraytextbox[0, 2].Text);
                            A.kj = Convert.ToInt32(arraytextbox[1, 2].Text);
                            A.kk = Convert.ToInt32(arraytextbox[2, 2].Text);
                            //first = A;
                        }
                    }
                    if ((string)element2.SelectedItem == "vector")
                    {
                        //second = new vector();
                        b.i = Convert.ToInt32(arraytextbox1[0, 1].Text);
                        b.j = Convert.ToInt32(arraytextbox1[1, 1].Text);
                        b.k = Convert.ToInt32(arraytextbox1[2, 1].Text);
                        //second = a;
                        vect2 = true;
                    }
                    else
                    {
                        //second = new tensor();
                        B.ii = Convert.ToInt32(arraytextbox1[0, 0].Text);
                        B.ij = Convert.ToInt32(arraytextbox1[1, 0].Text);
                        B.ik = Convert.ToInt32(arraytextbox1[2, 0].Text);

                        B.ji = Convert.ToInt32(arraytextbox1[0, 1].Text);
                        B.jj = Convert.ToInt32(arraytextbox1[1, 1].Text);
                        B.jk = Convert.ToInt32(arraytextbox1[2, 1].Text);

                        B.ki = Convert.ToInt32(arraytextbox1[0, 2].Text);
                        B.kj = Convert.ToInt32(arraytextbox1[1, 2].Text);
                        B.kk = Convert.ToInt32(arraytextbox1[2, 2].Text);
                        //second = A;
                    }


                    if ((string)actCombobox.SelectedItem == "*")
                    {
                        if ((vect1)&&(vect2))
                        {
                            var answ = ScalarMultiplication(a, b);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                        else if ((vect1) && !(vect2))
                        {
                            var answ = ScalarMultiplication(a, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                        else if (!(vect1) && (vect2))
                        {
                            var answ = ScalarMultiplication(A, b);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                        else
                        {
                            var answ = ScalarMultiplication(A, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "×")
                    {
                        if ((vect1) && (vect2))
                        {
                            var answ = VectorMultiplication(a, b);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                        else if ((vect1) && !(vect2))
                        {
                            var answ = VectorMultiplication(a, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                        else if (!(vect1) && (vect2))
                        {
                            var answ = VectorMultiplication(A, b);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }

                    }
                    else if ((string)actCombobox.SelectedItem == "⊗")
                    {
                        if ((vect1) && (vect2))
                        {
                            var answ = DiadMultiplication(a, b);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "**")
                    {
                        if (!(vect1) && !(vect2))
                        {
                            var answ = TwiceScalar(A, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "*×")
                    {
                        if (!(vect1) && !(vect2))
                        {
                            var answ = ScalarVector(A, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "×*")
                    {
                        if (!(vect1) && !(vect2))
                        {
                            var answ = VectorScalar(A, B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "××")
                    {
                        if (!(vect1) && !(vect2))
                        {
                            var answ = TwiceVector(A,B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                    else if ((string)actCombobox.SelectedItem == "tr")
                    {
                        if (!vect2)
                        {
                            var answ = Trace(B);
                            WriteAnsw(answTextbox, answ);
                            //answerLabel.Text = answ.ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    ClearAnsw(answTextbox);
                   // throw;
                }
            }

            void Erase(object sender, EventArgs e)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arraytextbox[i, j].Text = "";
                        arraytextbox1[i, j].Text = "";
                        ClearAnsw(answTextbox);
                    }
                }

            }

            void Copy(object sender, EventArgs e)
            {
                if ((string)actCombobox.SelectedItem != "tr")
                {
                    
                        if ((answTextbox[1, 1].Enabled)&&(!answTextbox[2, 2].Enabled))
                        {
                            element1.SelectedIndex = 0;

                            //copy vector
                            arraytextbox[0, 1].Text = answTextbox[0, 1].Text;
                            arraytextbox[1, 1].Text = answTextbox[1, 1].Text;
                            arraytextbox[2, 1].Text = answTextbox[2, 1].Text;
                        }
                        if ((answTextbox[2, 2].Enabled) && (arraytextbox[0, 0].Enabled))
                        {
                            element1.SelectedIndex = 1;
                            //copy tensor
                            arraytextbox[0, 0].Text = answTextbox[0, 0].Text;
                            arraytextbox[1, 0].Text = answTextbox[1, 0].Text;
                            arraytextbox[2, 0].Text = answTextbox[2, 0].Text;

                            arraytextbox[0, 1].Text = answTextbox[0, 1].Text;
                            arraytextbox[1, 1].Text = answTextbox[1, 1].Text;
                            arraytextbox[2, 1].Text = answTextbox[2, 1].Text;

                            arraytextbox[0, 2].Text = answTextbox[0, 2].Text;
                            arraytextbox[1, 2].Text = answTextbox[1, 2].Text;
                            arraytextbox[2, 2].Text = answTextbox[2, 2].Text;
                        }
                    
                }
            }
        }

        public void ChangePanel(ComboBox c,TextBox[,] array)
        {
            if ((string)c.SelectedItem == "vector")
            {
                for (int i = 0; i < 3; i++)
                {
                    array[i, 0].Text = "";
                    array[i, 2].Text = "";

                    array[i, 0].Enabled = false;
                    array[i, 2].Enabled = false;
                }
            }
            else if ((string)c.SelectedItem == "tensor")
            {
                for (int i = 0; i < 3; i++)
                {
                    array[i, 0].Enabled = true;
                    array[i, 2].Enabled = true;
                }
            }

        }

        public void WriteAnsw(TextBox[,] textBoxArray, float answ)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBoxArray[i, j].Text = "";
                    textBoxArray[i, j].Enabled = false;
                }
            }
            textBoxArray[0, 1].Enabled = true;
            textBoxArray[0, 1].Text = answ.ToString();
        }
        public void WriteAnsw(TextBox[,] textBoxArray, vector answ)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBoxArray[i, j].Text = "";
                    textBoxArray[i, j].Enabled = false;
                }
            }
            textBoxArray[0, 1].Enabled = true;
            textBoxArray[1, 1].Enabled = true;
            textBoxArray[2, 1].Enabled = true;

            textBoxArray[0, 1].Text = answ.i.ToString();
            textBoxArray[1, 1].Text = answ.j.ToString();
            textBoxArray[2, 1].Text = answ.k.ToString();
        }
        public void WriteAnsw(TextBox[,] textBoxArray, tensor answ)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBoxArray[i, j].Enabled = true;
                }
            }
            textBoxArray[0, 0].Text = answ.ii.ToString();
            textBoxArray[0, 1].Text = answ.ji.ToString();
            textBoxArray[0, 2].Text = answ.ki.ToString();

            textBoxArray[1, 0].Text = answ.ij.ToString();
            textBoxArray[1, 1].Text = answ.jj.ToString();
            textBoxArray[1, 2].Text = answ.kj.ToString();

            textBoxArray[2, 0].Text = answ.ik.ToString();
            textBoxArray[2, 1].Text = answ.jk.ToString();
            textBoxArray[2, 2].Text = answ.kk.ToString();
        }
        public void ClearAnsw(TextBox[,] textBoxArray)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBoxArray[i, j].Text = "";
                    textBoxArray[i, j].Enabled = false;
                }
            }
        }

        

        #region//Scalar

        /// <summary>
        /// a * b
        /// </summary>
        public float ScalarMultiplication(vector a, vector b)
        {
            float temp = a.i * b.i + a.j * b.j + a.k * b.k;

            LogForm.a += "\n" +"\n" + "Step : "+ "\n" +" =" 
                                          + a.i.ToString() + "i" + " * " + b.i.ToString() + "i" + " + "
                                          + a.j.ToString() + "j" + " * " + b.j.ToString() + "j" + " + "
                                          + a.k.ToString() + "k" + " * " + b.k.ToString() + "k" 
                                          + " = " + temp.ToString();
  
            return temp;
        }

        /// <summary>
        /// a * A
        /// </summary>
        public vector ScalarMultiplication(vector a, tensor A)
        {
            var temp = new vector();
            temp.i = a.i * A.ii + a.j * A.ji + a.k * A.ki;
            temp.j = a.i * A.ij + a.j * A.jj + a.k * A.kj;
            temp.k = a.i * A.ik + a.j * A.jk + a.k * A.kk;

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "i =" + a.i.ToString() + "i" + " * " + A.ii.ToString() + "ii" + " + "
                                      + a.j.ToString() + "j" + " * " + A.ji.ToString() + "ji" + " + "
                                      + a.k.ToString() + "k" + " * " + A.ki.ToString() + "ki" 
                                          + " = " + temp.i.ToString();

            LogForm.a += "\n"  + "j =" + a.i.ToString() + "i" + " * " + A.ij.ToString() + "ij" + " + "
                                       + a.j.ToString() + "j" + " * " + A.jj.ToString() + "jj" + " + "
                                       + a.k.ToString() + "k" + " * " + A.kj.ToString() + "kj" 
                                          + " = " + temp.j.ToString();

            LogForm.a += "\n"  + "k =" + a.i.ToString() + "i" + " * " + A.ik.ToString() + "ik" + " + "
                                       + a.j.ToString() + "j" + " * " + A.jk.ToString() + "jk" + " + "
                                       + a.k.ToString() + "k" + " * " + A.kk.ToString() + "kk" 
                                          + " = " + temp.k.ToString();

            return temp;
        }

        /// <summary>
        /// A * a
        /// </summary>
        public vector ScalarMultiplication(tensor A, vector a)
        {
            var temp = new vector();

            temp.i = A.ii * a.i + A.ij * a.j + A.ik * a.k;
            temp.j = A.ji * a.i + A.jj * a.j + A.jk * a.k;
            temp.k = A.ki * a.i + A.kj * a.j + A.kk * a.k;

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "i =" + A.ii.ToString() + "ii" + " * " + a.i.ToString() + "i" + " + "
                                      + A.ij.ToString() + "ij" + " * " + a.j.ToString() + "j" + " + "
                                      + A.ik.ToString() + "ik" + " * " + a.k.ToString() + "k" 
                                          + " = " + temp.i.ToString();

            LogForm.a += "\n" + "j =" + A.ji.ToString() + "ji" + " * " + a.i.ToString() + "i" + " + "
                                      + A.jj.ToString() + "jj" + " * " + a.j.ToString() + "j" + " + "
                                      + A.jk.ToString() + "jk" + " * " + a.k.ToString() + "k" 
                                          + " = " + temp.j.ToString();

            LogForm.a += "\n" + "k =" + A.ki.ToString() + "ki" + " * " + a.i.ToString() + "i" + " + "
                                      + A.kj.ToString() + "kj" + " * " + a.j.ToString() + "j" + " + "
                                      + A.kk.ToString() + "kk" + " * " + a.k.ToString() + "k" 
                                          + " = " + temp.k.ToString();

            return temp;
        }

        /// <summary>
        /// A * B
        /// </summary>
        public tensor ScalarMultiplication(tensor A, tensor B)
        {
            var temp = new tensor();

            temp.ii = A.ii * B.ii + A.ij * B.ji + A.ik * B.ki;
            temp.ij = A.ii * B.ij + A.ij * B.jj + A.ik * B.kj;
            temp.ik = A.ii * B.ik + A.ij * B.jk + A.ik * B.kk;
           
            temp.ji = A.ji * B.ii + A.jj * B.ji + A.jk * B.ki;
            temp.jj = A.ji * B.ij + A.jj * B.jj + A.jk * B.kj;
            temp.jk = A.ji * B.ik + A.jj * B.jk + A.jk * B.kk;

            temp.ki = A.ki * B.ii + A.kj * B.ji + A.kk * B.ki;
            temp.kj = A.ki * B.ij + A.kj * B.jj + A.kk * B.kj;
            temp.kk = A.ki * B.ik + A.kj * B.jk + A.kk * B.kk;

            #region

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "ii =" + A.ii.ToString() + "ii" + " * " + B.ii.ToString() + "ii" + " + "
                                       + A.ij.ToString() + "ij" + " * " + B.ji.ToString() + "ji" + " + "
                                       + A.ik.ToString() + "ik" + " * " + B.ki.ToString() + "ki" 
                                          + " = " + temp.ii.ToString();

            LogForm.a += "\n" + "ij =" + A.ii.ToString() + "ii" + " * " + B.ij.ToString() + "ij" + " + "
                                       + A.ij.ToString() + "ij" + " * " + B.jj.ToString() + "jj" + " + "
                                       + A.ik.ToString() + "ik" + " * " + B.kj.ToString() + "kj" 
                                          + " = " + temp.ij.ToString();

            LogForm.a += "\n" + "ik =" + A.ii.ToString() + "ii" + " * " + B.ik.ToString() + "ik" + " + "
                                       + A.ij.ToString() + "ij" + " * " + B.jk.ToString() + "jk" + " + "
                                       + A.ik.ToString() + "ik" + " * " + B.kk.ToString() + "kk" 
                                          + " = " + temp.ik.ToString();

            LogForm.a += "\n" + "ji =" + A.ji.ToString() + "ji" + " * " + B.ii.ToString() + "ii" + " + "
                                       + A.jj.ToString() + "jj" + " * " + B.ji.ToString() + "ji" + " + "
                                       + A.jk.ToString() + "jk" + " * " + B.ki.ToString() + "ki" 
                                          + " = " + temp.ji.ToString();

            LogForm.a += "\n" + "jj =" + A.ji.ToString() + "ji" + " * " + B.ij.ToString() + "ij" + " + "
                                       + A.jj.ToString() + "jj" + " * " + B.jj.ToString() + "jj" + " + "
                                       + A.jk.ToString() + "jk" + " * " + B.kj.ToString() + "kj" 
                                          + " = " + temp.jj.ToString();

            LogForm.a += "\n" + "jk =" + A.ji.ToString() + "ji" + " * " + B.ik.ToString() + "ik" + " + "
                                       + A.jj.ToString() + "jj" + " * " + B.jk.ToString() + "jk" + " + "
                                       + A.jk.ToString() + "jk" + " * " + B.kk.ToString() + "kk" 
                                          + " = " + temp.jk.ToString();

            LogForm.a += "\n" + "ki =" + A.ki.ToString() + "ki" + " * " + B.ii.ToString() + "ii" + " + "
                                       + A.kj.ToString() + "kj" + " * " + B.ji.ToString() + "ji" + " + "
                                       + A.kk.ToString() + "kk" + " * " + B.ki.ToString() + "ki" 
                                          + " = " + temp.ki.ToString();

            LogForm.a += "\n" + "kj =" + A.ki.ToString() + "ki" + " * " + B.ij.ToString() + "ij" + " + "
                                       + A.kj.ToString() + "kj" + " * " + B.jj.ToString() + "jj" + " + "
                                       + A.kk.ToString() + "kk" + " * " + B.kj.ToString() + "kj" 
                                          + " = " + temp.kj.ToString();

            LogForm.a += "\n" + "kk =" + A.ki.ToString() + "ki" + " * " + B.ik.ToString() + "ik" + " + "
                                       + A.kj.ToString() + "kj" + " * " + B.jk.ToString() + "jk" + " + "
                                       + A.kk.ToString() + "kk" + " * " + B.kk.ToString() + "kk" 
                                          + " = " + temp.kk.ToString();
            #endregion

            return temp;
        }

        #endregion

        #region//Vector

        /// <summary>
        /// a × b
        /// </summary>
        public vector VectorMultiplication(vector a, vector b)
        {
            vector temp = new vector();
            temp.i = a.j * b.k - b.j * a.k;
            temp.j = b.i * a.k - a.i * b.k;
            temp.k = a.i * b.j - b.i * a.j;

            LogForm.a += "\n"+"\n" + "Step : " +
                         "\n" + "i =" + a.j.ToString() + "j" + " * " + b.k.ToString() + "k" + " - "
                                      + a.k.ToString() + "k" + " * " + b.j.ToString() + "j" 
                                          + " = " + temp.i.ToString();

            LogForm.a += "\n" + "j =" + a.k.ToString() + "k" + " * " + b.i.ToString() + "i" + " - "
                                      + a.i.ToString() + "i" + " * " + b.k.ToString() + "k" 
                                          + " = " + temp.j.ToString();

            LogForm.a += "\n" + "k =" + a.i.ToString() + "i" + " * " + b.j.ToString() + "j" + " - "
                                      + a.j.ToString() + "j" + " * " + b.i.ToString() + "i" 
                                          + " = " + temp.k.ToString();


            return temp;
        }

        /// <summary>
        /// a × A
        /// </summary>
        public tensor VectorMultiplication(vector a, tensor A)
        {
            var temp = new tensor();

            temp.ii = a.j * A.ki - a.k * A.ji;
            temp.ij = a.j * A.kj - a.k * A.jj;
            temp.ik = a.j * A.kk - a.k * A.jk;

            temp.ji = -a.i * A.ki + a.k * A.ii;
            temp.jj = -a.i * A.kj + a.k * A.ij;
            temp.jk = -a.i * A.kk + a.k * A.ik;

            temp.ki = a.i * A.ji - a.j * A.ii;
            temp.kj = a.i * A.jj - a.j * A.ij;
            temp.kk = a.i * A.jk - a.j * A.ik;

            #region

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "ii =" + a.j.ToString() + "j" + " * " + A.ki.ToString() + "ki" + " - "
                                       + a.k.ToString() + "k" + " * " + A.ji.ToString() + "ji" 
                                          + " = " + temp.ii.ToString();

            LogForm.a += "\n" + "ij =" + a.j.ToString() + "j" + " * " + A.kj.ToString() + "kj" + " - "
                                       + a.k.ToString() + "k" + " * " + A.jj.ToString() + "jj" 
                                          + " = " + temp.ij.ToString();

            LogForm.a += "\n" + "ik =" + a.j.ToString() + "j" + " * " + A.kk.ToString() + "kk" + " - "
                                       + a.k.ToString() + "k" + " * " + A.jk.ToString() + "jk" 
                                          + " = " + temp.ik.ToString();

            LogForm.a += "\n" + "ji =" + a.k.ToString() + "k" + " * " + A.ii.ToString() + "ii" + " - "
                                       + a.i.ToString() + "i" + " * " + A.ki.ToString() + "ki" 
                                          + " = " + temp.ji.ToString();

            LogForm.a += "\n" + "jj =" + a.k.ToString() + "k" + " * " + A.ij.ToString() + "ij" + " - "
                                       + a.i.ToString() + "i" + " * " + A.kj.ToString() + "kj" 
                                          + " = " + temp.jj.ToString();

            LogForm.a += "\n" + "jk =" + a.k.ToString() + "k" + " * " + A.ik.ToString() + "ik" + " - "
                                       + a.i.ToString() + "i" + " * " + A.kk.ToString() + "kk" 
                                          + " = " + temp.jk.ToString();

            LogForm.a += "\n" + "ki =" + a.i.ToString() + "i" + " * " + A.ji.ToString() + "ji" + " - "
                                       + a.j.ToString() + "j" + " * " + A.ii.ToString() + "ii" 
                                          + " = " + temp.ki.ToString();

            LogForm.a += "\n" + "kj =" + a.i.ToString() + "i" + " * " + A.jj.ToString() + "jj" + " - "
                                       + a.j.ToString() + "j" + " * " + A.ij.ToString() + "ij" 
                                          + " = " + temp.kj.ToString();

            LogForm.a += "\n" + "kk =" + a.i.ToString() + "i" + " * " + A.jk.ToString() + "jk" + " - "
                                       + a.j.ToString() + "j" + " * " + A.ik.ToString() + "ik" 
                                          + " = " + temp.kk.ToString();
            #endregion

            return temp;
        }

        /// <summary>
        /// A × a
        /// </summary>
        public tensor VectorMultiplication(tensor A, vector a)
        {
            var temp = new tensor();

            temp.ii = -A.ik * a.j + A.ij * a.k;
            temp.ij =  A.ik * a.i - A.ii * a.k;
            temp.ik = -A.ij * a.i + A.ii * a.j;

            temp.ji = -A.jk * a.j + A.jj * a.k;
            temp.jj =  A.jk * a.i - A.ji * a.k;
            temp.jk = -A.jj * a.i + A.ji * a.j;

            temp.ki = -A.kk * a.j + A.kj * a.k;
            temp.kj =  A.kk * a.i - A.ki * a.k;
            temp.kk = -A.kj * a.i + A.ki * a.j;

            #region

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "ii =" + A.ij.ToString() + "ij" + " * " + a.k.ToString() + "k" + " - "
                                       + A.ik.ToString() + "ik" + " * " + a.j.ToString() + "j"
                                          + " = " + temp.ii.ToString();

            LogForm.a += "\n" + "ij =" + A.ik.ToString() + "ik" + " * " + a.i.ToString() + "i" + " - "
                                       + A.ii.ToString() + "ii" + " * " + a.k.ToString() + "k"
                                          + " = " + temp.ij.ToString();

            LogForm.a += "\n" + "ik =" + A.ii.ToString() + "ii" + " * " + a.j.ToString() + "j" + " - "
                                       + A.ij.ToString() + "ij" + " * " + a.i.ToString() + "i" 
                                          + " = " + temp.ik.ToString();

            LogForm.a += "\n" + "ji =" + A.jj.ToString() + "jj" + " * " + a.k.ToString() + "k" + " - "
                                       + A.jk.ToString() + "jk" + " * " + a.j.ToString() + "j"
                                          + " = " + temp.ji.ToString();

            LogForm.a += "\n" + "jj =" + A.jk.ToString() + "jk" + " * " + a.i.ToString() + "i" + " - "
                                       + A.ji.ToString() + "ji" + " * " + a.k.ToString() + "k" 
                                          + " = " + temp.jj.ToString();

            LogForm.a += "\n" + "jk =" + A.ji.ToString() + "ji" + " * " + a.j.ToString() + "j" + " - "
                                       + A.jj.ToString() + "jj" + " * " + a.i.ToString() + "i" 
                                          + " = " + temp.jk.ToString();

            LogForm.a += "\n" + "ki =" + A.kj.ToString() + "kj" + " * " + a.k.ToString() + "k" + " - "
                                       + A.kk.ToString() + "kk" + " * " + a.j.ToString() + "j" 
                                          + " = " + temp.ki.ToString();

            LogForm.a += "\n" + "kj =" + A.kk.ToString() + "kk" + " * " + a.i.ToString() + "i" + " - "
                                       + A.ki.ToString() + "ki" + " * " + a.k.ToString() + "k" 
                                          + " = " + temp.kj.ToString();

            LogForm.a += "\n" + "kk =" + A.ki.ToString() + "ki" + " * " + a.j.ToString() + "j" + " - "
                                       + A.kj.ToString() + "kj" + " * " + a.i.ToString() + "i" 
                                          + " = " + temp.kk.ToString();
            #endregion

            return temp;
        }

        #endregion

        #region//TwiceMultiplication

        /// <summary>
        /// A ** B
        /// </summary>
        public float TwiceScalar(tensor A, tensor B)
        {
            float temp;
            temp = A.ii * B.ii
                 + A.ij * B.ji
                 + A.ik * B.ki
                 + A.ji * B.ij
                 + A.jj * B.jj
                 + A.jk * B.kj
                 + A.ki * B.ik 
                 + A.kj * B.jk 
                 + A.kk * B.kk
                 ;

            LogForm.a += "\n" + "\n" + "Step : " +
                 "\n" + " =" + A.ii.ToString() + "ii" + " * " + B.ii.ToString() + "ii" + " + " +
                               A.ij.ToString() + "ij" + " * " + B.ji.ToString() + "ji" + " + " +
                               A.ik.ToString() + "ik" + " * " + B.ki.ToString() + "ki" + " + " +
                               A.ji.ToString() + "ji" + " * " + B.ij.ToString() + "ij" + " + " +
                               A.jj.ToString() + "jj" + " * " + B.jj.ToString() + "jj" + " + " +
                               A.jk.ToString() + "jk" + " * " + B.kj.ToString() + "kj" + " + " +
                               A.ki.ToString() + "ki" + " * " + B.ik.ToString() + "ik" + " + " +
                               A.kj.ToString() + "kj" + " * " + B.jk.ToString() + "jk" + " + " +
                               A.kk.ToString() + "kk" + " * " + B.kk.ToString() + "kk"
                                          + " = " + temp.ToString(); ;
                             


            return temp;
        }

        /// <summary>
        /// A *× B
        /// </summary>
        public vector ScalarVector(tensor A, tensor B)
        {
            vector temp = new vector();

            temp.i = A.ji * B.ik + A.jj * B.jk + A.jk * B.kk
                   -(A.ki * B.ij + A.kj * B.jj + A.kk * B.kj);

            temp.j = A.ki * B.ii + A.kj * B.ji + A.kk * B.ki
                   -(A.ii * B.ik + A.ij * B.jk + A.ik * B.kk);

            temp.k = A.ii * B.ij + A.ij * B.jj + A.ik * B.kj
                   -(A.ji * B.ii + A.jj * B.ji + A.jk * B.ki);

            # region
            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "i =" + A.ji.ToString() + "ji" + " * " + B.ik.ToString() + "ik" + " + "
                                      + A.jj.ToString() + "jj" + " * " + B.jk.ToString() + "jk" + " + "
                                      + A.jk.ToString() + "jk" + " * " + B.kk.ToString() + "kk" + " - "
                                      + A.ki.ToString() + "ki" + " * " + B.ij.ToString() + "ij" + " - "
                                      + A.kj.ToString() + "kj" + " * " + B.jj.ToString() + "jj" + " - "
                                      + A.kk.ToString() + "kk" + " * " + B.kj.ToString() + "kj"
                                          + " = " + temp.i.ToString();

            LogForm.a += "\n" + "j =" + A.ki.ToString() + "ki" + " * " + B.ii.ToString() + "ii" + " + "
                                      + A.kj.ToString() + "kj" + " * " + B.ji.ToString() + "ji" + " + "
                                      + A.kk.ToString() + "kk" + " * " + B.ki.ToString() + "ki" + " - "
                                      + A.ii.ToString() + "ii" + " * " + B.ik.ToString() + "ik" + " - "
                                      + A.ij.ToString() + "ij" + " * " + B.jk.ToString() + "jk" + " - "
                                      + A.ik.ToString() + "ik" + " * " + B.kk.ToString() + "kk"
                                          + " = " + temp.j.ToString();

            LogForm.a += "\n" + "k =" + A.ii.ToString() + "ii" + " * " + B.ij.ToString() + "ij" + " + "
                                      + A.ij.ToString() + "ij" + " * " + B.jj.ToString() + "jj" + " + "
                                      + A.ik.ToString() + "ik" + " * " + B.kj.ToString() + "kj" + " - "
                                      + A.ji.ToString() + "ji" + " * " + B.ii.ToString() + "ii" + " - "
                                      + A.jj.ToString() + "jj" + " * " + B.ji.ToString() + "ji" + " - "
                                      + A.jk.ToString() + "jk" + " * " + B.ki.ToString() + "ki"
                                          + " = " + temp.k.ToString();
            #endregion

            return temp;
        }

        /// <summary>
        /// A ×* B
        /// </summary>
        public vector VectorScalar(tensor A, tensor B)
        {
            var temp = new vector();

            temp.i = A.ij * B.ki + A.jj * B.kj + A.kj * B.kk
                   -(A.ik * B.ji + A.jk * B.jj + A.kk * B.jk);

            temp.j = A.ik * B.ii + A.jk * B.ij + A.kk * B.ik
                   -(A.ii * B.ki + A.ji * B.kj + A.ki * B.kk);

            temp.k = A.ii * B.ji + A.ji * B.jj + A.ki * B.jk
                   -(A.ij * B.ii + A.jj * B.ij + A.kj * B.ik);

            #region
            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "i =" + A.ij.ToString() + "ij" + " * " + B.ki.ToString() + "ki" + " + "
                                      + A.jj.ToString() + "jj" + " * " + B.kj.ToString() + "kj" + " + "
                                      + A.kj.ToString() + "kj" + " * " + B.kk.ToString() + "kk" + " - "
                                      + A.ik.ToString() + "ik" + " * " + B.ji.ToString() + "ji" + " - "
                                      + A.jk.ToString() + "jk" + " * " + B.jj.ToString() + "jj" + " - "
                                      + A.kk.ToString() + "kk" + " * " + B.jk.ToString() + "jk"
                                          + " = " + temp.i.ToString();

            LogForm.a += "\n" + "j =" + A.ik.ToString() + "ik" + " * " + B.ii.ToString() + "ii" + " + "
                                      + A.jk.ToString() + "jk" + " * " + B.ij.ToString() + "ij" + " + "
                                      + A.kk.ToString() + "kk" + " * " + B.ik.ToString() + "ik" + " - "
                                      + A.ii.ToString() + "ii" + " * " + B.ki.ToString() + "ki" + " - "
                                      + A.ji.ToString() + "ji" + " * " + B.kj.ToString() + "kj" + " - "
                                      + A.ki.ToString() + "ki" + " * " + B.kk.ToString() + "kk"
                                          + " = " + temp.j.ToString();

            LogForm.a += "\n" + "k =" + A.ii.ToString() + "ii" + " * " + B.ji.ToString() + "ji" + " + "
                                      + A.ji.ToString() + "ji" + " * " + B.jj.ToString() + "jj" + " + "
                                      + A.ki.ToString() + "ki" + " * " + B.jk.ToString() + "jk" + " - "
                                      + A.ij.ToString() + "ij" + " * " + B.ii.ToString() + "ii" + " - "
                                      + A.jj.ToString() + "jj" + " * " + B.ij.ToString() + "ij" + " - "
                                      + A.kj.ToString() + "kj" + " * " + B.ik.ToString() + "ik"
                                          + " = " + temp.k.ToString();
            #endregion

            return temp;
        }

        /// <summary>
        /// A ×× B
        /// </summary>
        public tensor TwiceVector(tensor A, tensor B)
        {
            tensor temp = new tensor();

            temp.ii = A.jj * B.kk + A.kk * B.jj
                    -(A.kj * B.kj + A.jk * B.jk);

            temp.ij = A.ik * B.jk + A.kj * B.ki
                    -(A.ij * B.kk + A.kk * B.ji);

            temp.ik = A.ij * B.kj + A.jk * B.ji
                    -(A.ik * B.jj + A.jj * B.ki);

           
            temp.ji = A.ki * B.kj + A.jk * B.ik
                    -(A.ji * B.kk + A.kk * B.ij);

            temp.jj = A.ii * B.kk + A.kk * B.ii
                    -(A.ki * B.ki + A.ik * B.ik);

            temp.jk = A.ji * B.ki + A.ik * B.ij
                    -(A.ii * B.kj + A.jk * B.ii);
            
            temp.ki = A.ji * B.jk + A.kj * B.ij
                    -(A.jj * B.ik + A.ki * B.jj);

            temp.kj = A.ki * B.ji + A.ij * B.ik
                    -(A.ii * B.jk + A.kj * B.ii);

            temp.kk = A.ii * B.jj + A.jj * B.ii
                    -(A.ij * B.ij + A.ji * B.ji);

            #region

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "ii =" + A.jj.ToString() + "jj" + " * " + B.kk.ToString() + "kk" + " + " +
                                         A.kk.ToString() + "kk" + " * " + B.jj.ToString() + "jj" + " - " +
                                         A.kj.ToString() + "kj" + " * " + B.kj.ToString() + "kj" + " - " +
                                         A.jk.ToString() + "jk" + " * " + B.jk.ToString() + "jk"
                                          + " = " + temp.ii.ToString();

            LogForm.a += "\n" + "ij =" + A.ik.ToString() + "ik" + " * " + B.jk.ToString() + "jk" + " + " +
                                         A.kj.ToString() + "kj" + " * " + B.ki.ToString() + "ki" + " - " +
                                         A.ij.ToString() + "ij" + " * " + B.kk.ToString() + "kk" + " - " +
                                         A.kk.ToString() + "kk" + " * " + B.ji.ToString() + "ji"
                                          + " = " + temp.ij.ToString();

            LogForm.a += "\n" + "ik =" + A.ij.ToString() + "ij" + " * " + B.kj.ToString() + "kj" + " + " +
                                         A.jk.ToString() + "jk" + " * " + B.ji.ToString() + "ji" + " - " +
                                         A.ik.ToString() + "ik" + " * " + B.jj.ToString() + "jj" + " - " +
                                         A.jj.ToString() + "jj" + " * " + B.ki.ToString() + "ki"
                                          + " = " + temp.ik.ToString();

            LogForm.a += "\n" + "ji =" + A.ki.ToString() + "ki" + " * " + B.kj.ToString() + "kj" + " + " +
                                         A.jk.ToString() + "jk" + " * " + B.ik.ToString() + "ik" + " - " +
                                         A.ji.ToString() + "ji" + " * " + B.kk.ToString() + "kk" + " - " +
                                         A.kk.ToString() + "kk" + " * " + B.ij.ToString() + "ij"
                                          + " = " + temp.ji.ToString();

            LogForm.a += "\n" + "jj =" + A.ii.ToString() + "ii" + " * " + B.kk.ToString() + "kk" + " + " +
                                         A.kk.ToString() + "kk" + " * " + B.ii.ToString() + "ii" + " - " +
                                         A.ki.ToString() + "ki" + " * " + B.ki.ToString() + "ki" + " - " +
                                         A.ik.ToString() + "ik" + " * " + B.ik.ToString() + "ik"
                                          + " = " + temp.jj.ToString();

            LogForm.a += "\n" + "jk =" + A.ji.ToString() + "ji" + " * " + B.ki.ToString() + "ki" + " + " +
                                         A.ik.ToString() + "ik" + " * " + B.ij.ToString() + "ij" + " - " +
                                         A.ii.ToString() + "ii" + " * " + B.kj.ToString() + "kj" + " - " +
                                         A.jk.ToString() + "jk" + " * " + B.ii.ToString() + "ii"
                                          + " = " + temp.jk.ToString();

            LogForm.a += "\n" + "ki =" + A.ji.ToString() + "ji" + " * " + B.jk.ToString() + "jk" + " + " +
                                         A.kj.ToString() + "kj" + " * " + B.ij.ToString() + "ij" + " - " +
                                         A.jj.ToString() + "jj" + " * " + B.ik.ToString() + "ik" + " - " +
                                         A.ki.ToString() + "ki" + " * " + B.jj.ToString() + "jj"
                                          + " = " + temp.ki.ToString();

            LogForm.a += "\n" + "kj =" + A.ki.ToString() + "ki" + " * " + B.ji.ToString() + "ji" + " + " +
                                         A.ij.ToString() + "ij" + " * " + B.ik.ToString() + "ik" + " - " +
                                         A.ii.ToString() + "ii" + " * " + B.jk.ToString() + "jk" + " - " +
                                         A.kj.ToString() + "kj" + " * " + B.ii.ToString() + "ii"
                                          + " = " + temp.kj.ToString();

            LogForm.a += "\n" + "kk =" + A.ii.ToString() + "ii" + " * " + B.jj.ToString() + "jj" + " + " +
                                         A.jj.ToString() + "jj" + " * " + B.ii.ToString() + "ii" + " - " +
                                         A.ij.ToString() + "ij" + " * " + B.ij.ToString() + "ij" + " - " +
                                         A.ji.ToString() + "ji" + " * " + B.ji.ToString() + "ji"
                                          + " = " + temp.kk.ToString();
            #endregion

            return temp;
        }

        /// <summary>
        /// A ** E
        /// </summary>
        public float Trace(tensor A)
        {
            var E = new tensor(1,0,0,
                               0,1,0,
                               0,0,1);

            return TwiceScalar(A,E);
        }

        #endregion

        /// <summary>
        /// [a × b] * c
        /// </summary>
        public float MixedMultiplication(vector a, vector b, vector c)
        {
            return ScalarMultiplication(VectorMultiplication(a, b), c);
        }

        /// <summary>
        /// a ⊗ b
        /// </summary>
        public tensor DiadMultiplication(vector a, vector b)
        {
            var temp = new tensor();

            temp.ii = a.i * b.i;
            temp.ij = a.i * b.j;
            temp.ik = a.i * b.k;

            temp.ji = a.j * b.i;
            temp.jj = a.j * b.j;
            temp.jk = a.j * b.k;

            temp.ki = a.k * b.i;
            temp.kj = a.k * b.j;
            temp.kk = a.k * b.k;

            #region

            LogForm.a += "\n" + "\n" + "Step : " +
                         "\n" + "ii =" + a.i.ToString() + "i" + " ⊗ " + b.i.ToString() + "i"
                                          + " = " + temp.ii.ToString();

            LogForm.a += "\n" + "ij =" + a.i.ToString() + "i" + " ⊗ " + b.j.ToString() + "j"
                                          + " = " + temp.ij.ToString();

            LogForm.a += "\n" + "ik =" + a.i.ToString() + "i" + " ⊗ " + b.k.ToString() + "k"
                                          + " = " + temp.ik.ToString();

            LogForm.a += "\n" + "ji =" + a.j.ToString() + "j" + " ⊗ " + b.i.ToString() + "i"
                                          + " = " + temp.ji.ToString();

            LogForm.a += "\n" + "jj =" + a.j.ToString() + "j" + " ⊗ " + b.j.ToString() + "j"
                                          + " = " + temp.jj.ToString();

            LogForm.a += "\n" + "jk =" + a.j.ToString() + "j" + " ⊗ " + b.k.ToString() + "k"
                                          + " = " + temp.jk.ToString();

            LogForm.a += "\n" + "ki =" + a.k.ToString() + "k" + " ⊗ " + b.i.ToString() + "i"
                                          + " = " + temp.ki.ToString();

            LogForm.a += "\n" + "kj =" + a.k.ToString() + "k" + " ⊗ " + b.j.ToString() + "j"
                                          + " = " + temp.kj.ToString();

            LogForm.a += "\n" + "kk =" + a.k.ToString() + "k" + " ⊗ " + b.k.ToString() + "k"
                                          + " = " + temp.kk.ToString();
            #endregion

            return temp;
        }
    }

    public class vector
    {
        public float i;
        public float j;
        public float k;

        public vector()
        {
            i = 0;
            j = 0;
            k = 0;
        }

        public vector(float fl)
        {
            i = fl;
            j = fl;
            k = fl;
        }

        public vector(float i, float j, float k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }

        public vector(float[] a)
        {
            if (a.Count()==3)
            {
                i = a[0];
                j = a[1];
                k = a[2];
            }
        }

        override public string ToString()
        {
            string a = "[";
            a += i.ToString() + ",";
            a += j.ToString() + ",";
            a += k.ToString() + "]";
            return a;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            vector temp = (vector)obj;

            if ((i == temp.i) && (j == temp.j) && (k == temp.k))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        { 
            return Convert.ToInt32(i*j*k);
        }
    }

    public class tensor
    {
        public float ii;
        public float ij;
        public float ik;

        public float ji;
        public float jj;
        public float jk;

        public float ki;
        public float kj;
        public float kk;

        public tensor(
            float ii, float ij, float ik,
            float ji, float jj, float jk,
            float ki, float kj, float kk
            )
        {
            this.ii = ii;
            this.ij = ij;
            this.ik = ik;

            this.ji = ji;
            this.jj = jj;
            this.jk = jk;

            this.ki = ki;
            this.kj = kj;
            this.kk = kk;
        }

        public tensor()
        {
            ii = 0;
            ij = 0;
            ik = 0;

            ji = 0;
            jj = 0;
            jk = 0;

            ki = 0;
            kj = 0;
            kk = 0;
        }

        public tensor(float fl)
        {
            ii = fl;
            ij = fl;
            ik = fl;

            ji = fl;
            jj = fl;
            jk = fl;

            ki = fl;
            kj = fl;
            kk = fl;
        }

        public override string ToString()
        {
            string a = "|";

            a += ii + ",";
            a += ij + ",";
            a += ik + "|";
            a += "\n";

            a += "|";
            a += ji + ",";
            a += jj + ",";
            a += jk + "|";
            a += "\n";

            a += "|";
            a += ki + ",";
            a += kj + ",";
            a += kk + "|";
            return a;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            tensor temp = (tensor)obj;

            if (   (ii == temp.ii) && (ij == temp.ij) && (ik == temp.ik)
                && (ji == temp.ji) && (jj == temp.jj) && (jk == temp.jk)
                && (ki == temp.ki) && (kj == temp.kj) && (kk == temp.kk) 
                )
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(ii * ij * ik 
                                 * ji * jj * jk 
                                 * ki * kj * kk);
        }
    }

    

    public class LogForm : Form
    {

        public static string a = "";

        public LogForm()
        {
           

            var panel = new Panel()
            {
                Location = new Point(10, 60),
                Size = new Size(350, 5000),
            };

            var log = new Label()
            {
                Location = new Point(10, 60),
                Size = new Size(340, 5000),
                Font = new Font("Arial", 12, FontStyle.Regular),
                Text = a,
            };
            
            VScrollBar scrollbar = new VScrollBar()
            {
                Dock = DockStyle.Right,
            };

            scrollbar.Scroll += Scrollevent;
            Load += Scrollevent;

            var button = new Button()
            {
                Location = new Point(10, 10),
                Size = new Size(100, 40),
                Text = "Update",
            };

            var buttonErase = new Button()
            {
                Location = new Point(120, 10),
                Size = new Size(100, 40),
                Text = "Erase",
            };

            button.Click += UpdateLog;
            buttonErase.Click += Erase;

            void Scrollevent(object sender, EventArgs e)
            {
                panel.Location = new Point(10, - scrollbar.Value * 150);
            }


            void UpdateLog(object sender, EventArgs e)
            {
                log.Text = a;


            }
            void Erase(object sender, EventArgs e)
            {
                a = "        Your log:";
                log.Text = a;
                log.Location = new Point(10, 60);

            }
            //panel.Controls.Add(button);
            //panel.Controls.Add(buttonErase);

            Controls.Add(button);
            Controls.Add(buttonErase);

            panel.Controls.Add(log);
            Controls.Add(panel);
            Controls.Add(scrollbar);


        }
        
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var my = new MyForm();
            my.Width = 720;
            my.Height = 340;

            


            Application.Run(my);
            //Application.Run(log);
        }
    }
}
