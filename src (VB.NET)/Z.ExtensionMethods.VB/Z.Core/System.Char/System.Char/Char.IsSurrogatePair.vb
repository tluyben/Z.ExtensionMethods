
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_98

	''' <summary>
	'''     Indicates whether the two specified  objects form a surrogate pair.
	''' </summary>
	''' <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
	''' <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
	''' <returns>
	'''     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF, and the numeric value of the
	'''     parameter ranges from U+DC00 through U+DFFF; otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsSurrogatePair(highSurrogate As [Char], lowSurrogate As [Char]) As [Boolean]
		Return [Char].IsSurrogatePair(highSurrogate, lowSurrogate)
	End Function
End Module


