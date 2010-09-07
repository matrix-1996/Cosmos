using System;
using CPUx86 = Cosmos.Compiler.Assembler.X86;
namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode( ILOpCode.Code.Leave )]
    public class Leave : ILOp
    {
        public Leave( Cosmos.Compiler.Assembler.Assembler aAsmblr )
            : base( aAsmblr )
        {
        }

        public override void Execute( MethodInfo aMethod, ILOpCode aOpCode )
        {
            new CPUx86.Jump { DestinationLabel = AppAssemblerNasm.TmpBranchLabel( aMethod, aOpCode ) };
        }


        // using System;
        // using System.IO;
        // 
        // 
        // using CPU = Cosmos.Compiler.Assembler.X86;
        // 
        // namespace Cosmos.IL2CPU.IL.X86 {
        // 	[OpCode(OpCodeEnum.Leave)]
        // 	public class Leave: Op {public readonly string TargetLabel;
        // 	public Leave(ILReader aReader, MethodInformation aMethodInfo)
        // 			: base(aReader, aMethodInfo) {
        // 			TargetLabel = GetInstructionLabel(aReader.OperandValueBranchPosition);
        // 		}
        // 		public override void DoAssemble() {
        //         new CPU.Jump { DestinationLabel = TargetLabel };
        // 		}
        // 	}
        // }

    }
}