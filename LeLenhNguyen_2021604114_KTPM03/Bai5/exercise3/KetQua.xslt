<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/KetQua.xsd"
>
    <xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<body>
				<h2>Danh sách điểm thi môn THVP (>= 5)</h2>
				<table border="1">
					<tr>
						<th>MaSv</th>
						<th>MaMh</th>
						<th>DiemThi</th>
					</tr>
					<xsl:for-each select="a:KQHT/a:SinhVien[a:MaMh='THVP' and a:DiemThi &gt;= 5]">
						<xsl:sort select="a:DiemThi" order="descending"/>
						<tr>
							<td>
								<xsl:value-of select="a:MaSv"/>
							</td>
							<td>
								<xsl:value-of select="a:MaMh"/>
							</td>
							<td>
								<xsl:value-of select="a:DiemThi"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
