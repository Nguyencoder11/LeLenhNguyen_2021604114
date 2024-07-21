<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:ns="http://tempuri.org/SinhVien.xsd"
>
    <xsl:output method="html" indent="yes"/>
	
	<!-- Khai bao namespace 'xmlns:ns="http://tempuri.org/SinhVien.xsd"' de goi de phan tu DSSV -->
	
    <xsl:template match="/">
		<html>
			<body>
				<h2>DANH SACH SINH VIEN</h2>
				<!-- Su dung xpath thong qua namespace voi //ns: -->
				<!-- Cac xpath sau cung su dung ns: tuong tu -->
				<table border="2" cellspacing="0" width="100%">
					<tr>
						<th>STT</th>
						<th>MaSV</th>
						<th>TenSV</th>
						<th>GioiTinh</th>
						<th>NgaySinh</th>
						<th>MaLop</th>
					</tr>
					<xsl:apply-templates select="//ns:Lop/ns:Sinhvien">
						<xsl:sort order="ascending" select="ns:Ten"/>
					</xsl:apply-templates>
				</table>
			</body>
		</html>
    </xsl:template>
	<xsl:template match="ns:Sinhvien">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="@MaSV"/>
			</td>
			<td>
				<xsl:value-of select="ns:Ten"/>
			</td>
			<td>
				<xsl:value-of select="ns:Gioitinh"/>
			</td>
			<td>
				<xsl:value-of select="ns:Ngaysinh"/>
			</td>
			<td>
				<xsl:value-of select="../@MaLop"/>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
