<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="goc">
		<xsl:variable name="so1" select="so[1]"/>
		<xsl:variable name="so2" select="so[2]"/>
		
		Số lớn nhất giữa 2 số <xsl:value-of select="$so1"/> và <xsl:value-of select="$so2"/> là: 
		
		<xsl:choose>
			<xsl:when test="$so1 > $so2">
				<xsl:value-of select="$so1"/>
			</xsl:when>
			<xsl:when test="$so1 &lt; $so2">
				<xsl:value-of select="$so2"/>
			</xsl:when>
			<xsl:otherwise>
				
			</xsl:otherwise>
		</xsl:choose>
    </xsl:template>
</xsl:stylesheet>
