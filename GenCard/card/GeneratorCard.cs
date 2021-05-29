/*
 * Created by SharpDevelop.
 * User: MAC
 * Date: 25/05/2021
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GenCard.card
{
	/// <summary>
	/// Description of GeneratorCard.
	/// </summary>
	public class GeneratorCard
	{
		Random rand = new Random();
		
		public GeneratorCard(){}
		
		public String GenCard(){
			
			return "Cartao Vitual: " + RandomNumber();
			
		}
		
		public String RandomNumber(){
			string numero=""; 
			for(int i=0; i<=15; i++){
				numero = numero +rand.Next(0, 9);
			}
			
    		return Convert.ToUInt64(numero).ToString(@"0000\ 0000\ 0000\ 0000");;
		}
		
	}
}
