﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialChar
{
	public class ComHangeul
	{
		public static string INITIALS = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ";
		public static string MEDIALS = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ";
		public static string FINALS = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ";

		public static ushort UNICODE_HANGEUL_BASE = 0xAC00;
		public static ushort UNICODE_HANGEUL_LAST = 0xD79F;


		public static string GetOneSyllableString(string sInputString, int iWeight)
		{
			if (string.IsNullOrEmpty(sInputString) == true) return "";
			string sResult = "";
			foreach (char cInput in sInputString)
			{
				char[] cSyllables = GetAllSyllables(cInput);

				if (cSyllables is null)
				{
					sResult += cInput;
				}
				else
				{
					int iIndex = ComFunc.GetWetghtReturn(iWeight, 0, 1);
					sResult += cSyllables[iIndex];
				}
			}

			return sResult;
		}

		public static string GetOneSyllableString(string sInputString, double dWeight)
		{
			int iWeight = Convert.ToInt32(Math.Round(dWeight * 100));
			return GetOneSyllableString(sInputString, iWeight);
		}

		public static string GetInitialsString(string sInput)
		{
			return GetOneSyllableString(sInput, 100);
		}

		/// <summary>
		/// Code from http://blog.naver.com/PostView.nhn?blogId=sunho0371&logNo=220948604603
		/// </summary>
		/// <param name="cInput"></param>
		/// <returns></returns>
		public static char[] GetAllSyllables(char cInput)
		{
			ushort shCheck = Convert.ToUInt16(cInput);


			if (shCheck > UNICODE_HANGEUL_LAST || shCheck < UNICODE_HANGEUL_BASE) return null;

			int iInputCode = shCheck - UNICODE_HANGEUL_BASE;
			int iFinalCode = iInputCode % 28; // 종성
			iInputCode = (iInputCode - iFinalCode) / 28;

			int iMedialCode = iInputCode % 21; // 중성
			iInputCode = (iInputCode - iMedialCode) / 21;

			int iInitialCode = iInputCode; // 초성

			char cInitial = INITIALS[iInitialCode];
			char cMedial = MEDIALS[iMedialCode];
			char cFinal = FINALS[iFinalCode];

			return new char[] { cInitial, cMedial, cFinal };
		}

	}
}