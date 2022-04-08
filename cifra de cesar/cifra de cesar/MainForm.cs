using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cifra_de_cesar
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void TranslateClick(object sender, EventArgs e)
		{
			string palavra = word.Text, aux = "", alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Variáveis tipo String
			char letra2; //Variável tipo Char
			int cont = 0, jump = 3; //Variáveis in Int
			
			//Programa utilizando Foreach
			/*foreach(char letra in palavra) //Para cada letra na palavra (word.Text)
			{
				int posicao = alfa.IndexOf(letra); //Posição vai receber as letras que se coincidem tanto na variável alfa quanto em word.Text
				cont = jump + posicao;
				if(cont > 25) //Se for maior que 25 (ou seja, se passar de Z)
				{
					cont -= 26;
				}
				letra2 = alfa[cont]; //variável letra2 receberá cada letra de alfa
				aux += letra2;
				traduzido.Text = aux; //o texto será mostrado no textBox "traduzido"
			}*/
			
			//Programa utilizando For
			for(int i = 0; i < palavra.Length; i++) //Para i = 0, i menor que o tamanho de palavra e i++
			{
				int posicao = alfa.IndexOf(palavra[i]); //Posição vai receber quais letras em alfa se coincidem em palavra
				cont = jump + posicao;
				if(cont > 25) //Se for maior que 25 (ou seja, se passar de Z)
				{
					cont -= 26;
				}
				letra2 = alfa[cont]; //variável letra2 receberá cada letra de alfa
				aux += letra2;
				traduzido.Text = aux; //o texto será mostrado no textBox "traduzido"
			}
		}	
	}
}
