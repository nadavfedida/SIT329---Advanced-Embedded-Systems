`timescale 1ns/1ns
module halfadder(
	output sum,
	output carry,
	input a,
	input b
	);
	xor xor1(sum, a, b);
	and and1(carry, a, b);
endmodule

module fulladder(
	output sum,
	output cout,
	input a,
	input b,
	input cin
	);
	wire x,y,z;
	halfadder h1(x, y, a ,b);
	halfadder h2(sum, z, x, cin);
	or or1(cout, z, y);
endmodule

module threebit(
	output S1,
	output S2,
	output S3,
	output cout3,
	input A1,
	input A2,
	input A3,
	input B1,
	input B2,
	input B3
	);
	wire W1, W2;
	halfadder bit1(S1, W1, A1, B1);
	fulladder bit2(S2, W2, A2, B2, W1);
	fulladder bit3(S3, cout3, A3, B3, W2);
endmodule