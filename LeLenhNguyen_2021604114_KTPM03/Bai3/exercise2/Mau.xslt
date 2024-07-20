<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:ns="http://tempuri.org/Mau.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<h2>BỆNH VIỆN ĐA KHOA</h2>
				<h2 align="center">DANH SÁCH BỆNH NHÂN</h2>

				<xsl:for-each select="//ns:khoa">
					<h2>Khoa:  <xsl:value-of select="ns:tenkhoa"/></h2>

					<table border="2" cellspacing="0" width="100%">
						<tr>
							<th>STT</th>
							<th>Họ tên</th>
							<th>Ngày nhập viện</th>
							<th>Số ngày điều trị</th>
							<th>Số tiền phải trả</th>
						</tr>
						<xsl:for-each select="ns:phong/ns:DSBN/ns:benhnhan">
							<tr>
								<td><xsl:value-of select="position()"/></td>
								<td><xsl:value-of select="ns:hoten"/></td>
								<td><xsl:value-of select="ns:ngaynhapvien"/></td>
								<td><xsl:value-of select="ns:songaynamvien"/></td>
								<td><xsl:value-of select="ns:songaynamvien*15000"/></td>
							</tr>
						</xsl:for-each>
					</table>
				</xsl:for-each>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
