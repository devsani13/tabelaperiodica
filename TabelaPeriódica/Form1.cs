using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaPeriódica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isToolTipVisible = false;

        private void btnh_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnh, "H");
                toolTip1.Show("Símbolo: H\rNome: Hidrogênio\rNº Atômico: 1\rMassa Atômica: 1,008\rTipo: Não Metal", btnh, e.Location);
            }
        }

        private void btnh_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnh);
            }
        }
        private void btnhe_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnhe, "He");
                toolTip1.Show("Símbolo: He\rNome: Hélio\rNº Atômico: 2\rMassa Atômica: 4,003\rTipo: Gás Nobre", btnhe, e.Location);
            }
        }

        private void btnhe_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnhe);
            }
        }
        private void btnli_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnli, "Li");
                toolTip1.Show("Símbolo: Li\rNome: Lítio\rNº Atômico: 3\rMassa Atômica: 6,941\rTipo: Metal Alcalino", btnli, e.Location);
            }
        }

        private void btnli_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnli);
            }
        }
        private void btnbe_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnbe, "Be");
                toolTip1.Show("Símbolo: Be\rNome: Berílio\rNº Atômico: 4\rMassa Atômica: 9,012\rTipo: Metal Alcalino-terroso", btnbe, e.Location);
            }
        }

        private void btnbe_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnbe);
            }
        }
        private void btnb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnb, "B");
                toolTip1.Show("Símbolo: B\rNome: Boro\rNº Atômico: 5\rMassa Atômica: 10,81\rTipo: Semimetal", btnb, e.Location);
            }
        }

        private void btnb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnb);
            }
        }
        private void btnc_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnc, "C");
                toolTip1.Show("Símbolo: C\rNome: Carbono\rNº Atômico: 6\rMassa Atômica: 12,01\rTipo: ão Metal", btnc, e.Location);
            }
        }

        private void btnc_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnc);
            }
        }
        private void btnn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnn, "N");
                toolTip1.Show("Símbolo: N\rNome: Nitrogênio\rNº Atômico: 7\rMassa Atômica: 14,01\rTipo: Não Metal", btnn, e.Location);
            }
        }

        private void btnn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnn);
            }
        }
        private void btno_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btno, "O");
                toolTip1.Show("Símbolo: O\rNome: Oxigênio\rNº Atômico: 8\rMassa Atômica: 16,00\rTipo: Não Metal", btno, e.Location);
            }
        }

        private void btno_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btno);
            }
        }
        private void btnf_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnf, "F");
                toolTip1.Show("Símbolo: F\rNome: Flúor\rNº Atômico: 9\rMassa Atômica: 19,00\rTipo: Halogênio", btnf, e.Location);
            }
        }

        private void btnf_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnf);
            }
        }
        private void btnne_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnne, "Ne");
                toolTip1.Show("Símbolo: Ne\rNome: Neônio\rNº Atômico: 10\rMassa Atômica: 20,18\rTipo: Gás nobre", btnne, e.Location);
            }
        }

        private void btnne_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnne);
            }
        }
        private void btnna_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnna, "Na");
                toolTip1.Show("Símbolo: Na\rNome: Sódio\rNº Atômico: 11\rMassa Atômica: 22,99\rTipo: Metal Alcalino", btnna, e.Location);
            }
        }

        private void btnna_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnna);
            }
        }
        private void btnmg_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmg, "Mg");
                toolTip1.Show("Símbolo: Mg\rNome: Magnésio\rNº Atômico: 12\rMassa Atômica: 24,31\rTipo: Metal Alcalino-terroso", btnmg, e.Location);
            }
        }

        private void btnmg_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmg);
            }
        }
        private void btnal_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnal, "Al");
                toolTip1.Show("Símbolo: Al\rNome: Alumínio\rNº Atômico: 13\rMassa Atômica: 26,98\rTipo: Metal do grupo 13", btnal, e.Location);
            }
        }

        private void btnal_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnal);
            }
        }
        private void btnsi_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsi, "Si");
                toolTip1.Show("Símbolo: Si\rNome: Silício\rNº Atômico: 14\rMassa Atômica: 28,09\rTipo: Semimetal", btnsi, e.Location);
            }
        }

        private void btnsi_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsi);
            }
        }
        private void btnp_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnp, "P");
                toolTip1.Show("Símbolo: P\rNome: Fósforo\rNº Atômico: 15\rMassa Atômica: 30,97\rTipo: Não Metal", btnp, e.Location);
            }
        }

        private void btnp_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnp);
            }
        }
        private void btns_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btns, "S");
                toolTip1.Show("Símbolo: S\rNome: Enxofre\rNº Atômico: 16\rMassa Atômica: 32,06\rTipo: Não Metal", btns, e.Location);
            }
        }

        private void btns_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btns);
            }
        }
        private void btncl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncl, "Cl");
                toolTip1.Show("Símbolo: Cl\rNome: Cloro\rNº Atômico: 17\rMassa Atômica: 35,45\rTipo: Halogênio", btncl, e.Location);
            }
        }

        private void btncl_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncl);
            }
        }
        private void btnar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnar, "Ar");
                toolTip1.Show("Símbolo: Ar\rNome: Argônio\rNº Atômico: 18\rMassa Atômica: 39,95\rTipo: Gás Nobre", btnar, e.Location);
            }
        }

        private void btnar_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnar);
            }
        }
        private void btnk_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnk, "K");
                toolTip1.Show("Símbolo: K\rNome: Potássio\rNº Atômico: 19\rMassa Atômica: 39,10\rTipo: Metal Alcalino", btnk, e.Location);
            }
        }

        private void btnk_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnk);
            }
        }
        private void btnca_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnca, "Ca");
                toolTip1.Show("Símbolo: Ca\rNome: Cálcio\rNº Atômico: 20\rMassa Atômica: 40,08\rTipo: Metal Alcalino-terroso", btnca, e.Location);
            }
        }

        private void btnca_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnca);
            }
        }
        private void btnsc_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsc, "Sc");
                toolTip1.Show("Símbolo: Sc\rNome: Escândio\rNº Atômico: 21\rMassa Atômica: 44,96\rTipo: Metal de Transição", btnsc, e.Location);
            }
        }

        private void btnsc_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsc);
            }
        }
        private void btnti_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnti, "Ti");
                toolTip1.Show("Símbolo: Ti\rNome: Titânio\rNº Atômico: 22\rMassa Atômica: 47,87\rTipo: Metal de Transição", btnti, e.Location);
            }
        }

        private void btnti_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnti);
            }
        }
        private void btnv_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnv, "V");
                toolTip1.Show("Símbolo: V\rNome: Vanádio\rNº Atômico: 23\rMassa Atômica: 50,94\rTipo: Metal de Transição", btnv, e.Location);
            }
        }

        private void btnv_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnv);
            }
        }
        private void btncr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncr, "Cr");
                toolTip1.Show("Símbolo: Cr\rNome: Cromo\rNº Atômico: 24\rMassa Atômica: 52,00\rTipo: Metal de Transição", btncr, e.Location);
            }
        }

        private void btncr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncr);
            }
        }
        private void btnmn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmn, "Mn");
                toolTip1.Show("Símbolo: Mn\rNome: Manganês\rNº Atômico: 25\rMassa Atômica: 54,94\rTipo: Metal de Transição", btnmn, e.Location);
            }
        }

        private void btnmn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmn);
            }
        }
        private void btnfe_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnfe, "Fe");
                toolTip1.Show("Símbolo: Fe\rNome: Ferro\rNº Atômico: 26\rMassa Atômica: 55,85\rTipo: Metal de Transição", btnfe, e.Location);
            }
        }

        private void btnfe_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnfe);
            }
        }
        private void btnco_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnco, "Co");
                toolTip1.Show("Símbolo: Co\rNome: Cobalto\rNº Atômico: 27\rMassa Atômica: 58,93\rTipo: Metal de Transição", btnco, e.Location);
            }
        }

        private void btnco_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnco);
            }
        }
        private void btnni_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnni, "Ni");
                toolTip1.Show("Símbolo: Ni\rNome: Níquel\rNº Atômico: 28\rMassa Atômica: 58,69\rTipo: Metal de Transição", btnni, e.Location);
            }
        }

        private void btnni_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnni);
            }
        }
        private void btncu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncu, "Cu");
                toolTip1.Show("Símbolo: Cu\rNome: Cobre\rNº Atômico: 29\rMassa Atômica: 63,55\rTipo: Metal de Transição", btncu, e.Location);
            }
        }

        private void btncu_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncu);
            }
        }
        private void btnzn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnzn, "Zn");
                toolTip1.Show("Símbolo: Zn\rNome: Zinco\rNº Atômico: 30\rMassa Atômica: 65,38\rTipo: Metal de Transição", btnzn, e.Location);
            }
        }

        private void btnzn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnzn);
            }
        }
        private void btnga_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnga, "Ga");
                toolTip1.Show("Símbolo: Ga\rNome: Gálio\rNº Atômico: 31\rMassa Atômica: 69,72\rTipo: Metal do grupo 13", btnga, e.Location);
            }
        }

        private void btnga_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnga);
            }
        }
        private void btnge_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnge, "Ge");
                toolTip1.Show("Símbolo: Ge\rNome: Germânio\rNº Atômico: 32\rMassa Atômica: 72,63\rTipo: Semimetal", btnge, e.Location);
            }
        }

        private void btnge_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnge);
            }
        }
        private void btnas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnas, "As");
                toolTip1.Show("Símbolo: As\rNome: Arsênio\rNº Atômico: 33\rMassa Atômica: 74,92\rTipo: Semimetal", btnas, e.Location);
            }
        }

        private void btnas_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnas);
            }
        }
        private void btnse_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnse, "Se");
                toolTip1.Show("Símbolo: Se\rNome: Selênio\rNº Atômico: 34\rMassa Atômica: 78,96\rTipo: Não Metal", btnse, e.Location);
            }
        }

        private void btnse_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnse);
            }
        }
        private void btnbr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnbr, "Br");
                toolTip1.Show("Símbolo: Br\rNome: Bromo\rNº Atômico: 35\rMassa Atômica: 79,90\rTipo: Halogênio", btnbr, e.Location);
            }
        }

        private void btnbr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnbr);
            }
        }
        private void btnkr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnkr, "Kr");
                toolTip1.Show("Símbolo: Kr\rNome: Criptônio\rNº Atômico: 36\rMassa Atômica: 83,80\rTipo: Gás Nobre", btnkr, e.Location);
            }
        }

        private void btnkr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnkr);
            }
        }
        private void btnrb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnrb, "Rb");
                toolTip1.Show("Símbolo: Rb\rNome: Rubídio\rNº Atômico: 37\rMassa Atômica: 85,47\rTipo: Metal Alcalino", btnrb, e.Location);
            }
        }

        private void btnrb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnrb);
            }
        }
        private void btnsr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsr, "Sr");
                toolTip1.Show("Símbolo: Sr\rNome: Estrôncio\rNº Atômico: 38\rMassa Atômica: 87,62\rTipo: Metal Alcalino-terroso", btnsr, e.Location);
            }
        }

        private void btnsr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsr);
            }
        }
        private void btny_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btny_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btny);
            }
        }
        private void btnzr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnzr, "Zr");
                toolTip1.Show("Símbolo: Zr\rNome: Zircônio\rNº Atômico: 40\rMassa Atômica: 91,22\rTipo: Metal de Transição", btnzr, e.Location);
            }
        }

        private void btnzr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnzr);
            }
        }
        private void btnnb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnnb, "Nb");
                toolTip1.Show("Símbolo: Nb\rNome: Nióbio\rNº Atômico: 41\rMassa Atômica: 92,91\rTipo:Metal de Transição ", btnnb, e.Location);
            }
        }

        private void btnnb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnnb);
            }
        }
        private void btnmo_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmo, "Mo");
                toolTip1.Show("Símbolo: Mo\rNome: Molibdênio\rNº Atômico: 42\rMassa Atômica: 95,94\rTipo: Metal de Transição", btnmo, e.Location);
            }
        }

        private void btnmo_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmo);
            }
        }
        private void btntc_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btntc, "Tc");
                toolTip1.Show("Símbolo: Tc\rNome: Tecnécio\rNº Atômico: 43\rMassa Atômica: 98\rTipo: Metal de Transição", btntc, e.Location);
            }
        }

        private void btntc_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btntc);
            }
        }
        private void btnru_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnru, "Ru");
                toolTip1.Show("Símbolo: Ru\rNome: Rutênio\rNº Atômico: 44\rMassa Atômica: 101,07\rTipo: Metal de Transição", btnru, e.Location);
            }
        }

        private void btnru_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnru);
            }
        }
        private void btnrh_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnrh, "Rh");
                toolTip1.Show("Símbolo: Rh\rNome: Ródio\rNº Atômico: 45\rMassa Atômica: 102,91\rTipo: Metal de Transição", btnrh, e.Location);
            }
        }

        private void btnrh_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnrh);
            }
        }
        private void btnpd_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpd, "Pd");
                toolTip1.Show("Símbolo: Pd\rNome: Paládio\rNº Atômico: 46\rMassa Atômica: 106,42\rTipo: Metal de Transição", btnpd, e.Location);
            }
        }

        private void btnpd_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpd);
            }
        }
        private void btnag_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnag, "Ag");
                toolTip1.Show("Símbolo: Ag\rNome: Prata\rNº Atômico: 47\rMassa Atômica: 107,87\rTipo: Metal de Transição", btnag, e.Location);
            }
        }

        private void btnag_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnag);
            }
        }
        private void btncd_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncd, "Cd");
                toolTip1.Show("Símbolo: Cd\rNome: Cádmio\rNº Atômico: 48\rMassa Atômica: 112,41\rTipo: Metal de Transição", btncd, e.Location);
            }
        }

        private void btncd_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncd);
            }
        }
        private void btnin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnin, "In");
                toolTip1.Show("Símbolo: In\rNome: Índio\rNº Atômico: 49\rMassa Atômica:114,82 \rTipo:Metal do grupo 13 ", btnin, e.Location);
            }
        }

        private void btnin_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnin);
            }
        }
        private void btnsn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsn, "Sn");
                toolTip1.Show("Símbolo: Sn\rNome: Estanho\rNº Atômico: 50\rMassa Atômica: 118,71\rTipo: Metal do grupo 14", btnsn, e.Location);
            }
        }

        private void btnsn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsn);
            }
        }
        private void btnsb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsb, "Sb");
                toolTip1.Show("Símbolo: Sb\rNome: Antimônio\rNº Atômico: 51\rMassa Atômica: 121,76\rTipo: Semimetal", btnsb, e.Location);
            }
        }

        private void btnsb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsb);
            }
        }
        private void btnte_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnte, "Te");
                toolTip1.Show("Símbolo: Te\rNome: Telúrio\rNº Atômico: 52\rMassa Atômica: 127,60\rTipo: Semimetal", btnte, e.Location);
            }
        }

        private void btnte_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnte);
            }
        }
        private void btni_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btni, "I");
                toolTip1.Show("Símbolo: I\rNome: Iodo\rNº Atômico: 53\rMassa Atômica: 126,90\rTipo: Halogênio", btni, e.Location);
            }
        }

        private void btni_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btni);
            }
        }
        private void btnxe_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnxe, "Xe");
                toolTip1.Show("Símbolo: Xe\rNome: Xenônio\rNº Atômico: 54\rMassa Atômica: 131,29\rTipo: Gás Nobre", btnxe, e.Location);
            }
        }

        private void btnxe_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnxe);
            }
        }
        private void btncs_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncs, "Cs");
                toolTip1.Show("Símbolo: Cs\rNome: Césio\rNº Atômico: 55\rMassa Atômica: 132,91\rTipo: Metal Alcalino", btncs, e.Location);
            }
        }

        private void btncs_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncs);
            }
        }
        private void btnba_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnba, "Ba");
                toolTip1.Show("Símbolo: Ba\rNome: Bário\rNº Atômico: 56\rMassa Atômica: 137,33\rTipo: Metal Alcalino-terroso", btnba, e.Location);
            }
        }

        private void btnba_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnba);
            }
        }
        private void btnla_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnla, "La");
                toolTip1.Show("Símbolo: La\rNome: Lantânio\rNº Atômico: 57\rMassa Atômica: 138,91\rTipo: Lantanídeo", btnla, e.Location);
            }
        }

        private void btnla_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnla);
            }
        }
        private void btnce_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnce, "Ce");
                toolTip1.Show("Símbolo: Ce\rNome: Cério\rNº Atômico: 58\rMassa Atômica: 140,12\rTipo: Lantanídeo", btnce, e.Location);
            }
        }

        private void btnce_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnce);
            }
        }
        private void btnpr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpr, "Pr");
                toolTip1.Show("Símbolo: Pr\rNome: Praseodímio\rNº Atômico: 59\rMassa Atômica: 140,91\rTipo: Lantanídeo", btnpr, e.Location);
            }
        }

        private void btnpr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpr);
            }
        }
        private void btnnd_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnnd, "Nd");
                toolTip1.Show("Símbolo: Nd\rNome: Neodímio\rNº Atômico: 60\rMassa Atômica: 144,24\rTipo: Lantanídeo", btnnd, e.Location);
            }
        }

        private void btnnd_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnnd);
            }
        }
        private void btnpm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpm, "Pm");
                toolTip1.Show("Símbolo: Pm\rNome: Promécio\rNº Atômico: 61\rMassa Atômica: 145\rTipo: Lantanídeo", btnpm, e.Location);
            }
        }

        private void btnpm_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpm);
            }
        }
        private void btnsm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsm, "Sm");
                toolTip1.Show("Símbolo: Sm\rNome: Samário\rNº Atômico: 62\rMassa Atômica: 150,36\rTipo: Lantanídeo", btnsm, e.Location);
            }
        }

        private void btnsm_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsm);
            }
        }
        private void btneu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btneu, "Eu");
                toolTip1.Show("Símbolo: Eu\rNome: Európio\rNº Atômico: 63\rMassa Atômica: 151,96\rTipo: Lantanídeo", btneu, e.Location);
            }
        }

        private void btneu_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btneu);
            }
        }
        private void btngd_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btngd, "Gd");
                toolTip1.Show("Símbolo: Gd\rNome: Gadolínio\rNº Atômico: 64\rMassa Atômica: 157,25\rTipo: Lantanídeo", btngd, e.Location);
            }
        }

        private void btngd_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btngd);
            }
        }
        private void btntb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btntb, "Tb");
                toolTip1.Show("Símbolo: Tb\rNome: Térbio\rNº Atômico: 65\rMassa Atômica: 158,93\rTipo: Lantanídeo", btntb, e.Location);
            }
        }

        private void btntb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btntb);
            }
        }
        private void btndy_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btndy, "Dy");
                toolTip1.Show("Símbolo: Dy\rNome: Disprósio\rNº Atômico: 66\rMassa Atômica: 162,50\rTipo: Lantanídeo", btndy, e.Location);
            }
        }

        private void btndy_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btndy);
            }
        }
        private void btnho_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnho, "Ho");
                toolTip1.Show("Símbolo: Ho\rNome: Hólmio\rNº Atômico: 67\rMassa Atômica: 164,93\rTipo: Lantanídeo", btnho, e.Location);
            }
        }

        private void btnho_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnho);
            }
        }
        private void btner_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btner, "Er");
                toolTip1.Show("Símbolo: Er\rNome: Erbímio\rNº Atômico: 68\rMassa Atômica: 167,26\rTipo: Lantanídeo", btner, e.Location);
            }
        }

        private void btner_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btner);
            }
        }
        private void btntm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btntm, "Tm");
                toolTip1.Show("Símbolo: Tm\rNome: Túlio\rNº Atômico: 69\rMassa Atômica: 168,93\rTipo: Lantanídeo", btntm, e.Location);
            }
        }

        private void btntm_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btntm);
            }
        }
        private void btnyb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnyb, "Yb");
                toolTip1.Show("Símbolo: Yb\rNome: Itérbio\rNº Atômico: 70\rMassa Atômica: 173,05\rTipo: Lantanídeo", btnyb, e.Location);
            }
        }

        private void btnyb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnyb);
            }
        }
        private void btnlu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnlu, "Lu");
                toolTip1.Show("Símbolo: Lu\rNome: Lutécio\rNº Atômico: 71\rMassa Atômica: 174,97\rTipo: Lantanídeo", btnlu, e.Location);
            }
        }

        private void btnlu_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnlu);
            }
        }
        private void btnhf_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnhf, "Hf");
                toolTip1.Show("Símbolo: Hf\rNome: Háfnio\rNº Atômico: 72\rMassa Atômica: 178,49\rTipo: Metal de Transição", btnhf, e.Location);
            }
        }

        private void btnhf_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnhf);
            }
        }
        private void btnta_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnta, "Ta");
                toolTip1.Show("Símbolo: Ta\rNome: Tântalo\rNº Atômico: 73\rMassa Atômica: 180,95\rTipo: Metal de Transição", btnta, e.Location);
            }
        }

        private void btnta_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnta);
            }
        }
        private void btnw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnw, "W");
                toolTip1.Show("Símbolo: W\rNome: Tungstênio\rNº Atômico: 74\rMassa Atômica: 183,84\rTipo: Metal de Transição", btnw, e.Location);
            }
        }

        private void btnw_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnw);
            }
        }
        private void btnre_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnre, "Re");
                toolTip1.Show("Símbolo: Re\rNome: Rênio\rNº Atômico: 75\rMassa Atômica: 186,21\rTipo: Metal de Transição", btnre, e.Location);
            }
        }

        private void btnre_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnre);
            }
        }
        private void btnos_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnos, "Os");
                toolTip1.Show("Símbolo: Os\rNome: Ósmio\rNº Atômico: 76\rMassa Atômica: 190,23\rTipo: Metal de Transição", btnos, e.Location);
            }
        }

        private void btnos_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnos);
            }
        }
        private void btnir_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnir, "Ir");
                toolTip1.Show("Símbolo: Ir\rNome: Irídio\rNº Atômico: 77\rMassa Atômica: 192,22\rTipo: Metal de Transição", btnir, e.Location);
            }
        }

        private void btnir_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnir);
            }
        }
        private void btnpt_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpt, "Pt");
                toolTip1.Show("Símbolo: Pt\rNome: Platina\rNº Atômico: 78\rMassa Atômica: 195,08\rTipo: Metal de Transição", btnpt, e.Location);
            }
        }

        private void btnpt_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpt);
            }
        }
        private void btnau_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnau, "Au");
                toolTip1.Show("Símbolo: Au\rNome: Ouro\rNº Atômico: 79\rMassa Atômica: 196,97\rTipo: Metal de Transição", btnau, e.Location);
            }
        }

        private void btnau_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnau);
            }
        }
        private void btnhg_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnhg, "Hg");
                toolTip1.Show("Símbolo: Hg\rNome: Mercúrio\rNº Atômico: 80\rMassa Atômica: 200,59\rTipo: Metal de Transição", btnhg, e.Location);
            }
        }

        private void btnhg_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnhg);
            }
        }
        private void btntl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btntl, "Tl");
                toolTip1.Show("Símbolo: Tl\rNome: Tálio\rNº Atômico: 81\rMassa Atômica: 204,38\rTipo: Metal do grupo 13", btntl, e.Location);
            }
        }

        private void btntl_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btntl);
            }
        }
        private void btnpb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpb, "Pb");
                toolTip1.Show("Símbolo: Pb\rNome: Chumbo\rNº Atômico: 82\rMassa Atômica: 207,2\rTipo: Metal do grupo 14", btnpb, e.Location);
            }
        }

        private void btnpb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpb);
            }
        }
        private void btnbi_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnbi, "Bi");
                toolTip1.Show("Símbolo: Bi\rNome: Bismuto\rNº Atômico: 83\rMassa Atômica: 208,98\rTipo: Semimetal", btnbi, e.Location);
            }
        }

        private void btnbi_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnbi);
            }
        }
        private void btnpo_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpo, "Po");
                toolTip1.Show("Símbolo: Po\rNome: Polônio\rNº Atômico: 84\rMassa Atômica: 209\rTipo: Semimetal", btnpo, e.Location);
            }
        }

        private void btnpo_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpo);
            }
        }
        private void btnat_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnat, "At");
                toolTip1.Show("Símbolo: At\rNome: Astato\rNº Atômico: 85\rMassa Atômica: 210\rTipo: Halogênio", btnat, e.Location);
            }
        }

        private void btnat_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnat);
            }
        }
        private void btnrn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnrn, "Rn");
                toolTip1.Show("Símbolo: Rn\rNome: Radônio\rNº Atômico: 86\rMassa Atômica: 222\rTipo: Gás Nobre", btnrn, e.Location);
            }
        }

        private void btnrn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnrn);
            }
        }
        private void btnfr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnfr, "Fr");
                toolTip1.Show("Símbolo: Fr\rNome: Frâncio\rNº Atômico: 87\rMassa Atômica: 223\rTipo: Metal Alcalino", btnfr, e.Location);
            }
        }

        private void btnfr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnfr);
            }
        }
        private void btnra_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnra, "Ra");
                toolTip1.Show("Símbolo: Ra\rNome: Rádio\rNº Atômico: 88\rMassa Atômica: 226\rTipo: Metal Alcalino-terroso", btnra, e.Location);
            }
        }

        private void btnra_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnra);
            }
        }
        private void btnac_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnac, "Ac");
                toolTip1.Show("Símbolo: Ac\rNome: Actínio\rNº Atômico: 89\rMassa Atômica: 227\rTipo: Actinídeo", btnac, e.Location);
            }
        }

        private void btnac_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnac);
            }
        }
        private void btnth_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnth, "Th");
                toolTip1.Show("Símbolo: Th\rNome: Tório\rNº Atômico: 90\rMassa Atômica: 232,04\rTipo: ", btnth, e.Location);
            }
        }

        private void btnth_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnth);
            }
        }
        private void btnpa_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpa, "Pa");
                toolTip1.Show("Símbolo: Pa\rNome: Protactínio\rNº Atômico: 91\rMassa Atômica: 231,04\rTipo: Actinídeo", btnpa, e.Location);
            }
        }

        private void btnpa_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpa);
            }
        }
        private void btnu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnu, "U");
                toolTip1.Show("Símbolo: U\rNome: Urânio\rNº Atômico: 92\rMassa Atômica: 238,03\rTipo: Actinídio", btnu, e.Location);
            }
        }

        private void btnu_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnu);
            }
        }
        private void btnnp_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnnp, "");
                toolTip1.Show("Símbolo: Np\rNome: Neptúnio\rNº Atômico: 93\rMassa Atômica: 237\rTipo: Actinídeo", btnnp, e.Location);
            }
        }

        private void btnnp_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnnp);
            }
        }
        private void btnpu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnpu, "Pu");
                toolTip1.Show("Símbolo: Pu\rNome: Plutônio\rNº Atômico: 94\rMassa Atômica: 244\rTipo: Actinídeo", btnpu, e.Location);
            }
        }

        private void btnpu_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnpu);
            }
        }
        private void btnam_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnam, "Am");
                toolTip1.Show("Símbolo: Am\rNome: Amerício\rNº Atômico: 95\rMassa Atômica: 243\rTipo: Actinídeo", btnam, e.Location);
            }
        }

        private void btnam_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnam);
            }
        }
        private void btncm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncm, "Cm");
                toolTip1.Show("Símbolo: Cm\rNome: Cúrio\rNº Atômico: 96\rMassa Atômica: 247\rTipo: Actinídeo", btncm, e.Location);
            }
        }

        private void btncm_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncm);
            }
        }
        private void btnbk_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnbk, "Bk");
                toolTip1.Show("Símbolo: Bk\rNome: Berquélio\rNº Atômico: 97\rMassa Atômica: 247\rTipo: Actinídeo", btnbk, e.Location);
            }
        }

        private void btnbk_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnbk);
            }
        }
        private void btncf_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncf, "Cf");
                toolTip1.Show("Símbolo: Cf\rNome: Califórnio\rNº Atômico: 98\rMassa Atômica: 251\rTipo: Actinídeo", btncf, e.Location);
            }
        }

        private void btncf_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncf);
            }
        }
        private void btnes_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnes, "Es");
                toolTip1.Show("Símbolo: Es\rNome: Einsteinio\rNº Atômico: 99\rMassa Atômica: 252\rTipo: Actinídeo", btnes, e.Location);
            }
        }

        private void btnes_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnes);
            }
        }
        private void btnfm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnfm, "Fm");
                toolTip1.Show("Símbolo: Fm\rNome: Férmio\rNº Atômico: 100\rMassa Atômica: 257\rTipo: Actinídeo", btnfm, e.Location);
            }
        }

        private void btnfm_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnfm);
            }
        }
        private void btnmd_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmd, "Md");
                toolTip1.Show("Símbolo: Md\rNome: Mendelévio\rNº Atômico: 101\rMassa Atômica: 258\rTipo: Actinídeo", btnmd, e.Location);
            }
        }

        private void btnmd_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmd);
            }
        }
        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnno, "No");
                toolTip1.Show("Símbolo: No\rNome: Nomélio\rNº Atômico: 102\rMassa Atômica: 259\rTipo: Actinídeo", btnno, e.Location);
            }
        }

        private void btnno_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnno);
            }
        }
        private void btnlr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnlr, "Lr");
                toolTip1.Show("Símbolo: Lr\rNome: Laurêncio\rNº Atômico: 103\rMassa Atômica: 262\rTipo: Actinídeo", btnlr, e.Location);
            }
        }

        private void btnlr_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnlr);
            }
        }
        private void btnrf_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnrf, "Rf");
                toolTip1.Show("Símbolo: Rf\rNome: Rutherfórdio\rNº Atômico: 104\rMassa Atômica: 267\rTipo: Metal de Transição", btnrf, e.Location);
            }
        }

        private void btnrf_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnrf);
            }
        }
        private void btndb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btndb, "Db");
                toolTip1.Show("Símbolo: Db\rNome: Dúbnio\rNº Atômico: 105\rMassa Atômica: 270\rTipo: Metal de Transição", btndb, e.Location);
            }
        }

        private void btndb_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btndb);
            }
        }
        private void btnsg_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnsg, "Sg");
                toolTip1.Show("Símbolo: Sg\rNome: Seabórgio\rNº Atômico: 106\rMassa Atômica: 271\rTipo: Metal de Transição", btnsg, e.Location);
            }
        }

        private void btnsg_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnsg);
            }
        }
        private void btnbh_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnbh, "Bh");
                toolTip1.Show("Símbolo: Bh\rNome: Bóhrio\rNº Atômico: 107\rMassa Atômica: 270\rTipo: Metal de Transição", btnbh, e.Location);
            }
        }

        private void btnbh_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnbh);
            }
        }
        private void btnhs_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnhs, "Hs");
                toolTip1.Show("Símbolo: Hs\rNome: Hássio\rNº Atômico: 108\rMassa Atômica: 277\rTipo: Metal de Transição", btnhs, e.Location);
            }
        }

        private void btnhs_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnhs);
            }
        }
        private void btnmt_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmt, "Mt");
                toolTip1.Show("Símbolo: Mt\rNome: Méitnerio\rNº Atômico: 109\rMassa Atômica: 278\rTipo: Metal de Transição", btnmt, e.Location);
            }
        }

        private void btnmt_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmt);
            }
        }
        private void btnds_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnds, "Ds");
                toolTip1.Show("Símbolo: Ds\rNome: Darmstádtio\rNº Atômico: 110\rMassa Atômica: 281\rTipo: Metal de Transição", btnds, e.Location);
            }
        }

        private void btnds_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnds);
            }
        }
        private void btnrg_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnrg, "Rg");
                toolTip1.Show("Símbolo: Rg\rNome: Roentgênio\rNº Atômico: 111\rMassa Atômica: 282\rTipo: Metal de Transição", btnrg, e.Location);
            }
        }

        private void btnrg_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnrg);
            }
        }
        private void btncn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btncn, "Cn");
                toolTip1.Show("Símbolo: Cn\rNome: Copernício\rNº Atômico: 112\rMassa Atômica: 285\rTipo: Metal de Transição", btncn, e.Location);
            }
        }

        private void btncn_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btncn);
            }
        }
        private void btnnh_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnnh, "Nh");
                toolTip1.Show("Símbolo: Nh\rNome: Nihônio\rNº Atômico: 113\rMassa Atômica: 286\rTipo: Metal do bloco P", btnnh, e.Location);
            }
        }

        private void btnnh_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnnh);
            }
        }
        private void btnfl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnfl, "Fl");
                toolTip1.Show("Símbolo: Fl\rNome: Fleróvio\rNº Atômico: 114\rMassa Atômica: 289\rTipo: Metal do bloco P", btnfl, e.Location);
            }
        }

        private void btnfl_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnfl);
            }
        }
        private void btnmc_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnmc, "Mc");
                toolTip1.Show("Símbolo: Mc\rNome: Moscóvio\rNº Atômico: 115\rMassa Atômica: 290\rTipo: Metal do bloco P", btnmc, e.Location);
            }
        }

        private void btnmc_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnmc);
            }
        }
        private void btnlv_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnlv, "Lv");
                toolTip1.Show("Símbolo: Lv\rNome: Livermório\rNº Atômico: 116\rMassa Atômica: 293\rTipo: Metal do bloco P", btnlv, e.Location);
            }
        }

        private void btnlv_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnlv);
            }
        }
        private void btnts_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnts, "Ts");
                toolTip1.Show("Símbolo: Ts\rNome: Tenneso\rNº Atômico: 117\rMassa Atômica: 294\rTipo: Halogênio", btnts, e.Location);
            }
        }

        private void btnts_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnts);
            }
        }
        private void btnog_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isToolTipVisible)
            {
                isToolTipVisible = true;
                toolTip1.SetToolTip(btnog, "Og");
                toolTip1.Show("Símbolo: Og\rNome: Ogânesson\rNº Atômico: 118\rMassa Atômica: 294\rTipo: Gás Nobre", btnog, e.Location);
            }
        }

        private void btnog_MouseLeave(object sender, EventArgs e)
        {
            if (isToolTipVisible)
            {
                isToolTipVisible = false;
                toolTip1.Hide(btnog);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy") +
                "     Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}