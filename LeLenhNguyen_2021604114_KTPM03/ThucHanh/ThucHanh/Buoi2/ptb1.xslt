<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="goc">
		<xsl:variable name="a" select="hsa"/>
		<xsl:variable name="b" select="hsb"/>
		
		Phương trình <xsl:value-of select="$a"/>X + <xsl:value-of select="$b"/> = 0
		
		<xsl:if test="$a = 0">
			<xsl:if test="$b = 0">
				<p>Vô số nghiệm</p>
			</xsl:if>
			<xsl:if test="$b != 0">
				<p>Vô nghiệm</p>
			</xsl:if>
		</xsl:if>
		<xsl:if test="$a != 0">
			<p>
				Nghiệm của phương trình là: <xsl:value-of select="format-number(-$b div $a, '#.##')"/>
			</p>
		</xsl:if>
    </xsl:template>
</xsl:stylesheet>
