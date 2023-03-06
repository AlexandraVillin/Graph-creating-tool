using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokGraf
{
    
        public partial class Form1 : Form
        {
        public struct Vertice
        {
            public Point p;
            public int index;
        }
        public struct Edge
        {
            public Vertice p1;
            public Vertice p2;
        }
        bool lever = false;
        public int EdgeNumber = 0;
        public int vcount = 0;
        public List<Edge> loe = new List<Edge>();
        public List<Vertice> lon = new List<Vertice>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawNode(MouseEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Rectangle r = new Rectangle(e.X - 15, e.Y - 15, 30, 30);
            Brush b = new SolidBrush(Color.White);
            Pen p = new Pen(b, 3);
            g.DrawEllipse(p, r);
            g.FillEllipse(Brushes.Black, r);
            Vertice ve;
            ve.p = new Point(e.X, e.Y);
            ve.index = vcount;
            lon.Add(ve);
            string drawString = ve.index.ToString();
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 14);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, e.X - 8, e.Y - 10, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
            vcount++;
        }
        private void DrawNode(Point e)
        {
            Graphics g = panel2.CreateGraphics();
            Rectangle r = new Rectangle(e.X - 15, e.Y - 15, 30, 30);
            Brush b = new SolidBrush(Color.White);
            Pen p = new Pen(b, 3);
            g.DrawEllipse(p, r);
            g.FillEllipse(Brushes.Black, r);
        }
        private void SelectedNode(Point e)
        {
            Graphics g = panel2.CreateGraphics();
            Rectangle r = new Rectangle(e.X - 16, e.Y - 16, 32, 32);
            Brush b = new SolidBrush(Color.Red);
            Pen p = new Pen(b, 3);
            g.DrawEllipse(p, r);
        }
        private void DeSelectedNode(Point e)
        {
            Graphics g = panel2.CreateGraphics();
            Rectangle r = new Rectangle(e.X - 16, e.Y - 16, 32, 32);
            Brush b = new SolidBrush(Color.White);
            Pen p = new Pen(b, 3);
            g.DrawEllipse(p, r);
        }
        public void DrawEdge(Vertice p1,Vertice p2)
        {
            Graphics g = panel2.CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b, 5);
            g.DrawLine(p,p1.p.X, p1.p.Y, p2.p.X, p2.p.Y);
            Edge ed;
            ed.p1 = p1;
            ed.p2 = p2;
            loe.Add(ed);
        }
        public void DrawEdge(Edge edge)
        {
            Graphics g = panel2.CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b, 5);
            g.DrawLine(p, edge.p1.p, edge.p2.p);
        }
        public void DrawEdgeLoop(Vertice p1)
        {
            Graphics g = panel2.CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b, 5);
            g.DrawEllipse(p, p1.p.X, p1.p.Y-25, 50, 50);
            Edge ed;
            ed.p1 = p1;
            ed.p2 = p1;
            loe.Add(ed);
        }
        public void DrawGraph()
        {
            for (int i = 0; i < loe.Count; i++)
            {
                DrawEdge(loe[i]);
            }
            for (int i = 0; i < lon.Count; i++)
            {
                DrawNode(lon[i].p);
            }
            lever = false;
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if(rbnode.Checked)
            {
                DrawNode(e);
            }
            else
            {
                for (int i = 0; i < lon.Count; i++)
                {
                    if(Math.Abs(Math.Sqrt(Math.Pow(lon[i].p.Y-e.Y,2)+Math.Pow(lon[i].p.X-e.X,2)))<=30)
                    {
                        if(lever)
                        {
                            if(i==EdgeNumber)
                            {
                                DrawEdgeLoop(lon[i]);
                            }
                            DrawEdge(lon[i],lon[EdgeNumber]);
                            lever = false;
                            DeSelectedNode(lon[EdgeNumber].p);
                            return;
                        }
                        lever=true;
                        EdgeNumber = i;
                        SelectedNode(lon[EdgeNumber].p);
                        return;
                    }
                }
                lever = false;
                if(lon.Count==0)
                {
                    return;
                }
                DeSelectedNode(lon[EdgeNumber].p);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph();
        }
        private void ClearSlate(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            g.FillRectangle(Brushes.White, 0, 0, panel2.Width,panel2.Height);
            loe = new List<Edge>();
            lon = new List<Vertice>();
            vcount = 0;
        }
        private void Lista_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < lon.Count; i++)
            {
                s = s + "\nindex: " + lon[i].index;
            }

            System.Windows.Forms.MessageBox.Show(s);
        }
        private void BFSstart_Click(object sender, EventArgs e)
        {
           
        }
        private void BFSstart_Click_1(object sender, EventArgs e)
        {
            GraphBFS graf = new GraphBFS(lon.Count);

            foreach (var n in loe)
            {
                graf.AddEdge(n.p1.index, n.p2.index);
                graf.AddEdge(n.p2.index, n.p1.index);

            }
            System.Windows.Forms.MessageBox.Show(graf.BFS(int.Parse(StartNode.Text)));
        }
        private void DFSstart_Click(object sender, EventArgs e)
        {
            GraphDFS graf = new GraphDFS(lon.Count);

            foreach (var n in loe)
            {
                graf.AddEdge(n.p1.index, n.p2.index);
                graf.AddEdge(n.p2.index, n.p1.index);

            }
            System.Windows.Forms.MessageBox.Show(graf.DFS(int.Parse(StartNode.Text)));
        }
    }
}
