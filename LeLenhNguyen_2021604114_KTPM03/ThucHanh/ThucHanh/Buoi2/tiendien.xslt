<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="sodien">
		<xsl:variable name="sodau" select="dau"/>
		<xsl:variable name="socuoi" select="cuoi"/>
		<p>Số điện là: <xsl:value-of select="$socuoi - $sodau"/></p>
		<p>
			Số tiền điện phải đóng là: 
			<xsl:choose>
				<xsl:when test="($socuoi - $sodau) &lt; 100">
					<xsl:value-of select="($socuoi - $sodau)*3000"/>
				</xsl:when>
				<xsl:when test="($socuoi - $sodau) &lt; 150">
					<xsl:value-of select="100*3000 + ($socuoi - $sodau)*4000"/>
				</xsl:when>
				<xsl:when test="($socuoi - $sodau) &lt; 200">
					<xsl:value-of select="100*3000 + 50*4000 + ($socuoi - $sodau)*4500"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="100*3000 + 50*4000 + 50*4500 + ($socuoi - $sodau)*5000"/>
				</xsl:otherwise>
			</xsl:choose>
		</p>
    </xsl:template>
</xsl:stylesheet>
