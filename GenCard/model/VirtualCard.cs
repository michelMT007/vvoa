/*
 * Created by SharpDevelop.
 * User: MAC
 * Date: 25/05/2021
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GenCard.model
{
	/// <summary>
	/// Description of VirtualCard.
	/// </summary>
	public class VirtualCard
	{
		public int ID {set;get;}
		public string email{set;get;}
		public string serialcard{set;get;}		
		
		public VirtualCard()
		{
		}
	}
}
