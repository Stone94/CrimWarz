using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public static class ExtensionMethods 
{
	public static string ToKMB(this float num)
	{
		if  (num > 999999999999999){
			return num.ToString ("0,,,,,.##### Quadrillion");
		} else if(num > 999999999999){
			return num.ToString ("0,,,,.#### Trillion");
		} else if (num > 999999999){
			return num.ToString ("0,,,.### Billion");
		} else if (num > 999999){
			return num.ToString ("0,,.## Million");
		} else if (num > 999){
			return num.ToString ("0,.#K");
		} else {
			return num.ToString ("0.##");
		}
	}



}
