<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/mau">
		<html>
			<body>
				<h3>BỆNH VIỆN ĐA KHOA</h3>
				<h1>DANH SÁCH BỆNH NHÂN</h1>
				<xsl:apply-templates select="khoa"></xsl:apply-templates>
			</body>
		</html>
    </xsl:template>

	<xsl:template match="khoa">
		<p>
			Khoa: <xsl:value-of select="tenkhoa"/>
		</p>
	</xsl:template>
</xsl:stylesheet>
    