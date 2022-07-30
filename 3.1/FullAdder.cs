`timescale 1ns/1ns
module fulladder(
	output sum, cout,
	input a, b, cin
	);
	wire x, y, z;
	halfadder h1(x, y, a ,b);
	halfadder h2(sum, z, x, cin);
	or or1(cout, z, y);
endmodule