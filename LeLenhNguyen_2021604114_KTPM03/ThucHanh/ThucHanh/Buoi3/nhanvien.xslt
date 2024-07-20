<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

	<!-- Cách 1: sử dụng for-each -->
    <!--<xsl:template match="congty">
		<html>
			<head>
				<style>
					.tieude{
						font-weight: bold;
						font-size: 25px;
						color: blue;
						background-color: red;
					}
					.so {
						text-align: right;
					}
					.chuoi {
						text-align: left;
					}
				</style>
			</head>
			<body>
				<h1 align="center">BẢNG LƯƠNG THÁNG 11-2009</h1>
				<xsl:for-each select="donvi">
					<h2>
						Mã đơn vị: <xsl:value-of select="tendv"/>
					</h2>
					<h2>
						Tên đơn vị: <xsl:value-of select="@madv"/>
					</h2>
					<h2>
						Điện thoại: <xsl:value-of select="dienthoai"/>
					</h2>
					<h2 align="center">DANH SÁCH NHÂN VIÊN</h2>
					<table border="2" width="100%" cellspacing="0">
						<tr class="tieude">
							<th>Số TT</th>
							<th>Mã NV</th>
							<th>Họ tên</th>
							<th>Ngày sinh</th>
							<th>Hệ số lương</th>
							<th>Lương</th>
						</tr>
						<xsl:for-each select="nhanvien[hsluong>=3]">
							<tr>
								<td class="so">
									<xsl:value-of select="position()"/>
								</td>
								<td class="chuoi">
									<xsl:value-of select="manv"/>
								</td>
								<td class="chuoi">
									<xsl:value-of select="hoten"/>
								</td>
								<td class="chuoi">
									<xsl:value-of select="ngaysinh"/>
								</td>
								<td class="so">
									<xsl:value-of select="hsluong"/>
								</td>
								<td class="so">
									<xsl:value-of select="hsluong*730000"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>

					<h2 align="right">THỦ TRƯỞNG ĐƠN VỊ</h2>
					<br></br>
				</xsl:for-each>
			</body>
		</html>
    </xsl:template>-->

	<!--Cách 2: sử dụng apply-templates--> 
	<xsl:template match="congty">
		<html>
			<head>
				<style>
					.tieude{
						font-weight: bold;
						font-size: 25px;
						color: blue;
						background-color: red;
					}
					.so {
						text-align: right;
					}
					.chuoi {
						text-align: left;
					}
				</style>
			</head>
			<body>
				<h1 align="center">BẢNG LƯƠNG THÁNG 11-2009</h1>
				<xsl:apply-templates select="donvi"></xsl:apply-templates>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="donvi">
		<h2>
			Mã đơn vị: <xsl:value-of select="tendv"/>
		</h2>
		<h2>
			Tên đơn vị: <xsl:value-of select="@madv"/>
		</h2>
		<h2>
			Điện thoại: <xsl:value-of select="dienthoai"/>
		</h2>
		<h2 align="center">DANH SÁCH NHÂN VIÊN</h2>
		<table border="2" width="100%" cellspacing="0">
			<tr class="tieude">
				<th>Số TT</th>
				<th>Mã NV</th>
				<th>Họ tên</th>
				<th>Ngày sinh</th>
				<th>Hệ số lương</th>
				<th>Lương</th>
			</tr>
			<xsl:apply-templates select="nhanvien[hsluong>=3]"></xsl:apply-templates>
		</table>

		<h2 align="right">THỦ TRƯỞNG ĐƠN VỊ</h2>
		<br></br>
	</xsl:template>

	<xsl:template match="nhanvien[hsluong>=3]">
		<tr>
			<td class="so">
				<xsl:value-of select="position()"/>
			</td>
			<td class="chuoi">
				<xsl:value-of select="manv"/>
			</td>
			<td class="chuoi">
				<xsl:value-of select="hoten"/>
			</td>
			<td class="chuoi">
				<xsl:value-of select="ngaysinh"/>
			</td>
			<td class="so">
				<xsl:value-of select="hsluong"/>
			</td>
			<td class="so">
				<xsl:value-of select="hsluong*730000"/>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
