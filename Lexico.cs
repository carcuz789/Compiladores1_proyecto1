using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiladores1_proyecto1
{
    class Lexico
    {
        public void AnaliLexico(char[] lexi)
        {
            int i = 0;
            int contador = 0;
            String conca = "";
            do
            {
                if (char.IsNumber(lexi[i]))
                {
                    do
                    {
                        conca += lexi[i];
                        i++;
                    } while (char.IsNumber(lexi[i]));
                    contador++;
                    tokens(conca, 2, contador);
                    conca = "";
                }
                else if (Char.IsLetter( lexi[i]))
                {
                    do
                    {
                        conca += lexi[i];
                        i++;
                        if (lexi[i].Equals("_") || lexi[i].Equals("-"))
                        {
                            conca += lexi[i];
                            i++;
                        }
                        if (Char.IsNumber(lexi[i]))
                        {
                            conca += lexi[i];
                            i++;
                        }
                    } while (Char.IsLetter(lexi[i]));
                     contador++;
                     tokens(conca,1,contador);
                     conca = ""; 
                }
                else  if ((int)lexi[i]>32&&(int)lexi[i]<=125)
                {
                    if ((int)lexi[i] > 32 && (int)lexi[i] <= 47)
                    {
                        contador++;
                        conca += lexi[i];
                        tokens(conca, (int)lexi[i], contador);
                        conca = "";
                        i++;
                    }
                    if ((int)lexi[i] >= 48 && (int)lexi[i] <= 57)
                    {
                        //no hace nada

                    }
                    if ((int)lexi[i] >= 58 && (int)lexi[i] <= 64)
                    {
                        contador++;
                        conca += lexi[i];
                        tokens(conca, (int)lexi[i], contador);
                        conca = "";
                        i++;
                    }
                    if ((int)lexi[i] >= 65 && (int)lexi[i] <= 90)
                    {
                        // no hace nada
                    }
                    if ((int)lexi[i] >= 91 && (int)lexi[i] <= 96)
                    {
                        //92 es la diagonal invertida 
                        if ((int)lexi[i] == 92)
                        {
                            int k = i + 1;
                            if (lexi[i].Equals('\''))
                            {
                                contador++;
                                conca += lexi[i];
                                tokens("\'", 39, contador);
                                conca = "";
                                i++;
                            }
                            else if (lexi[i].Equals('\"'))
                            {
                                contador++;
                                conca += lexi[i];
                                tokens("\"",34, contador);
                                conca = "";
                                i++;
                            }
                            else
                            {
                                contador++;
                                conca += lexi[i];
                                tokens(conca, (int)lexi[i], contador);
                                conca = "";
                                i++;
                            }
                        }
                        else if (lexi[i].Equals('\"'))
                        {
                            do
                            {
                                conca += lexi[i];
                                i++;
                            } while (lexi[i]!='\"');
                            conca += lexi[i];
                            i++;
                            contador++;
                            tokens(conca,689, contador);
                            conca = "";
                        }
                        else {
                            contador++;
                            conca += lexi[i];
                            tokens(conca, (int)lexi[i], contador);
                            conca = "";
                            i++;
                        }

                    }
                    if ((int)lexi[i] >= 123 && (int)lexi[i] <= 125)
                    {
                        contador++;
                        conca += lexi[i];
                        tokens(conca, (int)lexi[i], contador);
                        conca = "";
                        i++;
                    }

                }
                else  if (char.IsWhiteSpace(lexi[i]))
                {
                    //espacio en blanco
                    if (lexi[i].Equals('\n'))
                    {
                        contador++;
                        conca += lexi[i];
                        tokens(conca, 555, contador);
                        conca = "";
                        i++;
                    }
                    else if (lexi[i].Equals('\t'))
                    {
                        contador++;
                        conca += lexi[i];
                        tokens(conca, 556, contador);
                        conca = "";
                        i++;
                    }
                    else
                    {
                        i++;
                    }

                }
                else
                {
                    contador++;
                    conca += lexi[i];
                    tokens(conca, 8888, contador);
                    conca = "";
                    i++;
                }

            } while (i<lexi.Length);
        }
        public void tokens(String token , int id ,int num)
        {
        Form1.listok.Insertar(num, token, id);           
        }
    }
}
