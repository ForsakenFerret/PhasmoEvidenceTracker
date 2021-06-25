using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phasmo
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

		private void cbEMF_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}

		private void cbFinger_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}

		private void cbFreezing_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}

		private void cbOrbs_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}

		private void cbWriting_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}

		private void cbSpiritBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateGhostList();
		}


		private void UpdateGhostList()
		{
			// reset the table
			lblBanshee.Visible = true;
			lblDemon.Visible = true;
			lblHantu.Visible = true;
			lblJinn.Visible = true;
			lblMare.Visible = true;
			lblOni.Visible = true;
			lblPhantom.Visible = true;
			lblPoltergeist.Visible = true;
			lblRevenant.Visible = true;
			lblShade.Visible = true;
			lblSpirit.Visible = true;
			lblWraith.Visible = true;
			lblYokai.Visible = true;
			lblYurei.Visible = true;
			cbEMF.Visible = true;
			cbFinger.Visible = true;
			cbOrbs.Visible = true;
			cbFreezing.Visible = true;
			cbOrbs.Visible = true;
			cbWriting.Visible = true;
			cbSpiritBox.Visible = true;

			// set checkSum
			int checkSum = 0;

			// if EMF 5 is checked 
			if (cbEMF.Checked)
			{
				lblDemon.Visible = false;
				lblHantu.Visible = false;
				lblMare.Visible = false;
				lblPoltergeist.Visible = false;
				lblSpirit.Visible = false;
				lblWraith.Visible = false;
				lblYokai.Visible = false;
				lblYurei.Visible = false;
				checkSum += 1;
			}

			// if fingerprints is checked
			if (cbFinger.Checked)
			{
				lblDemon.Visible = false;
				lblJinn.Visible = false;
				lblMare.Visible = false;
				lblOni.Visible = false;
				lblPhantom.Visible = false;
				lblShade.Visible = false;
				lblYokai.Visible = false;
				lblYurei.Visible = false;
				checkSum += 2;
			}

			// if freezing temps are checked
			if (cbFreezing.Checked)
			{
				lblHantu.Visible = false;
				lblJinn.Visible = false;
				lblOni.Visible = false;
				lblPoltergeist.Visible = false;
				lblRevenant.Visible = false;
				lblShade.Visible = false;
				lblSpirit.Visible = false;
				lblYokai.Visible = false;
				checkSum += 4;
			}

			// if ghost orbs are checked
			if (cbOrbs.Checked)
			{
				lblBanshee.Visible = false;
				lblDemon.Visible = false;
				lblOni.Visible = false;
				lblRevenant.Visible = false;
				lblSpirit.Visible = false;
				lblWraith.Visible = false;
				checkSum += 8;
			}

			// if ghost writing is checked
			if (cbWriting.Checked)
			{
				lblBanshee.Visible = false;
				lblJinn.Visible = false;
				lblMare.Visible = false;
				lblPhantom.Visible = false;
				lblPoltergeist.Visible = false;
				lblWraith.Visible = false;
				checkSum += 16;
			}

			// if spirit box is checked
			if (cbSpiritBox.Checked)
			{
				lblBanshee.Visible = false;
				lblHantu.Visible = false;
				lblPhantom.Visible = false;
				lblRevenant.Visible = false;
				lblShade.Visible = false;
				lblYurei.Visible = false;
				checkSum += 32;
			}

			// remove evidence choices
			// 
			switch (checkSum)
			{
				case 3:
					cbOrbs.Visible = false;
					cbSpiritBox.Visible =false;
					break;

				case 5:
					cbWriting.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 6:
					cbOrbs.Visible = false;
					cbWriting.Visible = false;
					break;

				case 7: //banshee
					cbOrbs.Visible = false;
					cbWriting.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 9:
					cbFinger.Visible = false;
					break;

				case 10:
					cbEMF.Visible = false;
					cbFreezing.Visible = false;
					break;

				case 12:
					cbFinger.Visible = false;
					break;

				case 13: //phantom
					cbFinger.Visible = false;
					cbWriting.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 17:
					cbFreezing.Visible = false;
					break;

				case 18:
					cbFreezing.Visible = false;
					break;

				case 19: //revenent
					cbFreezing.Visible = false;
					cbOrbs.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 20:
					cbEMF.Visible = false;
					cbFinger.Visible = false;
					break;

				case 25: //shade
					cbFinger.Visible = false;
					cbFreezing.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 26: //hantu
					cbEMF.Visible = false;
					cbFreezing.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 28: //yurei
					cbEMF.Visible = false;
					cbFinger.Visible = false;
					cbSpiritBox.Visible = false;
					break;

				case 33:
					cbFinger.Visible = false;
					cbFreezing.Visible = false;
					break;

				case 34:
					cbEMF.Visible = false;
					break;

				case 36:
					cbEMF.Visible = false;
					break;

				case 38: //wraith
					cbEMF.Visible = false;
					cbOrbs.Visible = false;
					cbWriting.Visible = false;
					break;

				case 41: //jinn
					cbFinger.Visible = false;
					cbFreezing.Visible = false;
					cbWriting.Visible = false;
					break;

				case 42: //poltergeist
					cbEMF.Visible = false;
					cbFreezing.Visible = false;
					cbWriting.Visible = false;
					break;

				case 44: //mare
					cbEMF.Visible = false;
					cbFinger.Visible = false;
					cbWriting.Visible = false;
					break;

				case 49: //oni
					cbFinger.Visible = false;
					cbFreezing.Visible = false;
					cbOrbs.Visible = false;
					break;

				case 50: // spirit
					cbEMF.Visible = false;
					cbFreezing.Visible = false;
					cbOrbs.Visible = false;
					break;

				case 52: //demon
					cbEMF.Visible = false;
					cbFinger.Visible = false;
					cbOrbs.Visible = false;
					break;

				case 56: //yokai
					cbEMF.Visible = false;
					cbFinger.Visible = false;
					cbFreezing.Visible = false;
					break;

			}
		}

	}
}
