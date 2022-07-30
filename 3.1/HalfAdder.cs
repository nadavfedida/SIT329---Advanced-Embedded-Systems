`timescale 1ns/1ns
module halfadder(
	output sum, carry,
	input a, b
	);
	xor xor1(sum, a, b);
	and and1(carry, a, b);
endmodule