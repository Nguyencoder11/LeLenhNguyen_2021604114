<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:ns="http://tempuri.org/BenhNhan.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table border="0" width="100%" cellspacing="0">
					<tr>
						<td><h2 align="left">BENH VIEN DA KHOA</h2></td>
						<td><h2 align="center">DANH SACH BENH VIEN</h2></td>
					</tr>
					<xsl:for-each select="//ns:Khoa">
						<tr>
							<td>Khoa: <xsl:value-of select="ns:TenKhoa"/></td>
							<td>Phong: <xsl:value-of select="ns:Phong"/></td>
						</tr>
						<tr>
							<td colspan="2">
								<table border="2" cellspacing="0" width="100%">
									<tr>
										<th>Ma so BN</th>
										<th>Ho ten</th>
										<th>Ngay nhap vien</th>
										<th>So ngay dieu tri</th>
										<th>So tien phai tra</th>
									</tr>
									<xsl:for-each select="ns:BenhNhan">
										<tr>
											<td>
												<xsl:value-of select="@MasoBN"/>
											</td>
											<td>
												<xsl:value-of select="ns:HoTen"/>
											</td>
											<td>
												<xsl:value-of select="ns:NgayNhapVien"/>
											</td>
											<td>
												<xsl:value-of select="ns:NgayDieuTri"/>
											</td>
											<td>
												<xsl:value-of select="ns:NgayDieuTri*15000"/>
											</td>
										</tr>
									</xsl:for-each>
								</table>
								<br/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
