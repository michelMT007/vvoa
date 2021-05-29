/*
 * Created by SharpDevelop.
 * User: MAC
 * Date: 25/05/2021
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GenCard.card;
using GenCard.model;
using GenCard.data;
namespace GenCard
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Data dados = new Data();
			GeneratorCard gc = new GeneratorCard();
			VirtualCard vc = new VirtualCard();
			Console.WriteLine("Digite seu email por gentileza, para vincular ao seu Cartao Virtual. Obrigado! ");
			Console.WriteLine("Email:  ");
			string email = Console.ReadLine();
			vc.email = email;
			vc.serialcard=gc.GenCard();
			//dados.ListaCartaoVirtual(vc);
			Console.WriteLine("Seu cartao de credito Virtual foi gerado com sucesso!" );
			Console.WriteLine("Seu email Vinculado: "+vc.email );
			Console.WriteLine("Sua Chave do Cartão Virtual: "+vc.serialcard );
			//Console.WriteLine(dados);
			Console.ReadLine();
			
			// TODO: Implement Functionality Here
			
			Console.Write("________________________________________________________________________) \n");
			Console.Write("MAC - Michel A. Costa Dev");
			Console.ReadKey(true);
		}
	}
}