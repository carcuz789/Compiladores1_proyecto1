using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Compiladores1_proyecto1
{
public    class Noder
    {

     public   String value;

     public   int num;

     public   Noder left;

     public   Noder right;

     public   Noder(String item, int num)
        {
            this.num = num;
            this.value = item;
            this.right = null;
            this.left = null;
        }
    }
public    class tree
    {

        String concatenar = "";

        String con = "";

        String conk = "";

        //  A utility function to check if 'c' 
        //  is an operator 
        bool isUno(String c)
        {
            if ((c.Equals("+")
                        || (c.Equals("?") || c.Equals("*"))))
            {
                return true;
            }

            return false;
        }

        bool isDoris(String c)
        {
            if ((c.Equals("|") || c.Equals(".")))
            {
                return true;
            }

            return false;
        }

        //  Utility function to do inorder traversal 
        //  Returns root of constructed tree for given 
        //  postfix expression 
     public   Noder constructTree(ArrayList list)
        {
            Stack<Noder> st = new Stack<Noder>();
            Noder op2;
            Noder t;
            Noder t1;
            Noder t2;
            Noder op1;
            // de reversa mami
            for (int i = (list.Count - 1); (i >= 0); i--)
            {
                //  If operand, simply push into stack 
                if (this.isUno(list[i].ToString()))
                {
                    t = new Noder(list[i].ToString(), i);
                    op1 = st.Peek();
                    st.Pop();
                    t.left = op1;
                    st.Push(t);
                }
                else if (this.isDoris(list[i].ToString()))
                {
                    t = new Noder(list[i].ToString(), i);
                    op1 = st.Peek();
                    st.Pop();
                    op2 = st.Peek();
                    st.Pop();
                    t.left = op1;
                    t.right = op2;
                    st.Push(t);
                }
                else
                {
                    t = new Noder(list[i].ToString(), i);
                    st.Push(t);
                }

            }

            //  only element will be root of expression 
            //  tree 
            t = st.Peek();
            st.Pop();
            return t;
        }

        public void preOrder(Noder root)
        {
            if ((root != null))
            {
                if ((root.left != null))
                {
                    this.con = (this.con
                                + (root.num + (" -> "
                                + (root.left.num + ";\n"))));
                }

                if ((root.right != null))
                {
                    this.con = (this.con
                                + (root.num + ("->"
                                + (root.right.num + ";\n"))));
                }

                this.preOrder(root.left);
                //  System.out.printf("%d ", root.value);            
                this.concatenar += root.num + "[label= \" " + root.value.Replace("\"", "") + "\"];\n";
                if (root.value.Equals("."))
                {

                }
                else
                {
                    ListaConjuntos lista = new ListaConjuntos();
                    String verid = lista.retornar(Principal.ListaConjuntos.head, root.value);
                    this.conk = (this.conk + verid);
                }

                this.preOrder(root.right);
            }

        }

        public void ImprimirArbolin(Noder root)
        {
            this.preOrder(root);
            String conexion = "";
            int estado = 0;
            Principal.listaexparreg = this.conk;
            try
            {
                String ruta = "Avl.txt";
                FileStream file = new FileStream(ruta,FileMode.CreateNew);
                //  Si el archivo no existe es creado


                FileWriter fw = new FileWriter(file);
                BufferedWriter bw = new BufferedWriter(fw);
                using (StreamWriter writer = new StreamWriter(file))
                {

                }
                bw.write("digraph g {");
                bw.write(this.concatenar);
                bw.write(this.con);
                bw.write("}");
                bw.close();
                try
                {
                    //  Execute a command without arguments
                    String command = "dot -Tjpg Avl.txt -o AVL.jpg";
                    Process child = System.Runtime.getRuntime().exec(command);
                    child = Runtime.getRuntime().exec(command);
                }
                catch (Exception e)
                {

                }

            }
            catch (Exception )
            {

            }

        }
    }
