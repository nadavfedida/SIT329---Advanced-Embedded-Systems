`timescale 1ns/1ns

module ALU(
  input [1:0] A,B,             
  input [1:0] ALU_Sel,
  output [2:0] ALU_Out, 
  output CarryOut
    );
  reg [2:0] ALU_Result;
  wire [2:0] tmp;
 
    always @(*)
    begin
      case(ALU_Sel)
        2'b00: 
          ALU_Result = A + B ; 
        2'b01: 
          ALU_Result = A - B ;
        2'b10: 
          ALU_Result = A * B;
        2'b11: 
          ALU_Result = A/B;
        default: ALU_Result = A + B ; 
      endcase
    end
    assign ALU_Out = ALU_Result; 
    assign tmp = {1'b0,A} + {1'b0,B};
  	assign CarryOut = tmp[2];
endmodule