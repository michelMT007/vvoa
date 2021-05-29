/*
 * Created by SharpDevelop.
 * User: MAC
 * Date: 28/05/2021
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using GenCard.model;
using GenCard.card;

namespace GenCard.data
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		GeneratorCard gc = new GeneratorCard();
		static int NUM=1000;
		VirtualCard[] dadosVirtualCard = new VirtualCard[NUM];
		Boolean CONTINUE = true;
		
		int id=0;
		public Array ListaCartaoVirtual(VirtualCard v){
			
			while(CONTINUE){
				
				dadosVirtualCard[id].email=v.email;
				dadosVirtualCard[id].serialcard= gc.RandomNumber();
				id++;
				Console.ReadLine();
			}
			return dadosVirtualCard;
		}
		public Data()
		{
			
		}
	}
}
