<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/MonHoc.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table  border="2" width="100%" cellspacing="0">
					<tr>
						<th>MaMH</th>
						<th>TenMH</th>
						<th>SoGio</th>
					</tr>
					<xsl:for-each select="a:DSMH/a:MonHoc[a:SoGio>=40]">
						<tr>
							<td>
								<xsl:value-of select="@MaMon"/>
							</td>
							<td>
								<xsl:value-of select="a:TenMon"/>
							</td>
							<td>
								<xsl:value-of select="a:SoGio"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
