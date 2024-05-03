using GBX.NET;
using GBX.NET.Engines.Game;
using GBX.NET.LZO;
class EffectAlterations {
    static string[] StartBlock = new string[] {"PlatformTechStart","RoadTechStart","RoadDirtStart","RoadBumpStart","RoadIceStart","RoadWaterStart","PlatformTechStart","PlatformDirtStart","PlatformIceStart","PlatformGrassStart","PlatformPlasticStart","PlatformWaterStart"};
    static string[] MultilapBlock = new string[] {"PlatformTechMultilap","RoadTechMultilap","RoadDirtMultilap","RoadBumpMultilap","RoadIceMultilap","RoadWaterMultilap","PlatformTechMultilap","PlatformDirtMultilap","PlatformIceMultilap","PlatformGrassMultilap","PlatformPlasticMultilap","PlatformWaterMultilap"};
    //TODO missing MultilapIceWalls
    static string[] CPRoadBlock = new string[] {"RoadTechCheckpoint","RoadTechCheckpointSlopeUp","RoadTechCheckpointSlopeDown","RoadDirtCheckpoint","RoadDirtCheckpointSlopeUp","RoadDirtCheckpointSlopeDown","RoadBumpCheckpoint","RoadBumpCheckpointSlopeUp","RoadBumpCheckpointSlopeDown","RoadIceCheckpoint","RoadIceCheckpointSlopeUp","RoadIceCheckpointSlopeDown","RoadWaterCheckpoint","GateCheckpoint"};
    //TODO missing RoadIceWalls
    static string[] CPPlatformBlock = new string[] {"PlatformTechCheckpoint","PlatformTechCheckpointSlope2Up","PlatformTechCheckpointSlope2Down","PlatformTechCheckpointSlope2Right","PlatformTechCheckpointSlope2Left","PlatformPlasticCheckpoint","PlatformPlasticCheckpointSlope2Up","PlatformPlasticCheckpointSlope2Down","PlatformPlasticCheckpointSlope2Right","PlatformPlasticCheckpointSlope2Left","PlatformDirtCheckpoint","PlatformDirtCheckpointSlope2Up","PlatformDirtCheckpointSlope2Down","PlatformDirtCheckpointSlope2Right","PlatformDirtCheckpointSlope2Left","PlatformIceCheckpoint","PlatformIceCheckpointSlope2Up","PlatformIceCheckpointSlope2Down","PlatformIceCheckpointSlope2Right","PlatformIceCheckpointSlope2Left","PlatformGrassCheckpoint","PlatformGrassCheckpointSlope2Up","PlatformGrassCheckpointSlope2Down","PlatformGrassCheckpointSlope2Right","PlatformGrassCheckpointSlope2Left","PlatformWaterCheckpoint"};
    static string[] CPPlatformBlockTilt = new string[] {"RoadTechCheckpointTiltLeft","RoadTechCheckpointTiltRight","RoadDirtCheckpointTiltLeft","RoadDirtCheckpointTiltRight","RoadBumpCheckpointTiltLeft","RoadBumpCheckpointTiltRight"};
    static string[] GateCPStart32m = new string[] {"GateCheckpointLeft32m","GateCheckpointCenter32mv2","GateCheckpointRight32m","GateStartLeft32m","GateStartCenter32m","GateStartRight32m","GateMultilapLeft32m","GateMultilapCenter32m","GateMultilapRight32m"};
    static string[] GateCPStart16m = new string[] {"GateCheckpointLeft16m","GateCheckpointCenter16mv2","GateCheckpointRight16m","GateStartLeft16m","GateStartCenter16m","GateStartRight16m","GateMultilapLeft16m","GateMultilapCenter16m","GateMultilapRight16m"};
    static string[] GateCPStart8m = new string[] {"GateCheckpointLeft8m","GateCheckpointCenter8mv2","GateCheckpointRight8m","GateStartLeft8m","GateStartCenter8m","GateStartRight8m","GateMultilapLeft8m","GateMultilapCenter8m","GateMultilapRight8m"};
    static string[] DiagRight = new string[]{"RoadTechDiagRightMultilap","RoadDirtDiagRightMultilap","RoadBumpDiagRightMultilap","RoadIceDiagRightMultilap","RoadTechDiagRightCheckpoint","RoadDirtDiagRightCheckpoint","RoadBumpDiagRightCheckpoint"};
    static string[] DiagLeft = new string[]{"RoadTechDiagLeftMultilap","RoadDirtDiagLeftMultilap","RoadBumpDiagLeftMultilap","RoadIceDiagLeftMultilap","RoadTechDiagLeftCheckpoint","RoadDirtDiagLeftCheckpoint","RoadBumpDiagLeftCheckpoint"};
    public static void NoBrakes(Map map){
        BlockChange GateSpecialNoBrake = new BlockChange(BlockType.Block,"GateSpecialNoBrake",new Vec3(0,-16,1));
        map.placeRelative(StartBlock, GateSpecialNoBrake);
        map.placeRelative(MultilapBlock, GateSpecialNoBrake);
        map.placeRelative(CPRoadBlock, GateSpecialNoBrake);
        map.placeRelative(CPPlatformBlock, GateSpecialNoBrake);
        map.placeRelative(CPPlatformBlockTilt, new BlockChange(BlockType.Block,"GateSpecialNoBrake",new Vec3(0,-12,1)));
        map.placeRelative(DiagRight,new DiagBlockChange(BlockType.Block,"GateSpecialNoBrake",new Vec3(0,-16,1),LeftRight.Right));
        map.placeRelative(DiagLeft,new DiagBlockChange(BlockType.Block,"GateSpecialNoBrake",new Vec3(0,-16,1),LeftRight.Left));

        map.placeRelative(GateCPStart32m,new BlockChange(BlockType.Item,"GateSpecial32mNoBrake",new Vec3(0,0,1)));
        map.placeRelative(GateCPStart16m,new BlockChange(BlockType.Item,"GateSpecial16mNoBrake",new Vec3(0,0,1)));
        map.placeRelative(GateCPStart8m,new BlockChange(BlockType.Item,"GateSpecial8mNoBrake",new Vec3(0,0,1)));
        map.placeStagedBlocks();
    }

    public static void NoSteer(Map map){
        BlockChange GateSpecialNoSteering = new BlockChange(BlockType.Block,"GateSpecialNoSteering",new Vec3(0,-16,1));
        map.placeRelative(StartBlock, GateSpecialNoSteering);
        map.placeRelative(MultilapBlock, GateSpecialNoSteering);
        map.placeRelative(CPRoadBlock, GateSpecialNoSteering);
        map.placeRelative(CPPlatformBlock, GateSpecialNoSteering);
        map.placeRelative(CPPlatformBlockTilt, new BlockChange(BlockType.Block,"GateSpecialNoSteering",new Vec3(0,-12,1)));
        map.placeRelative(DiagRight,new DiagBlockChange(BlockType.Block,"GateSpecialNoSteering",new Vec3(0,-16,1),LeftRight.Right));
        map.placeRelative(DiagLeft,new DiagBlockChange(BlockType.Block,"GateSpecialNoSteering",new Vec3(0,-16,1),LeftRight.Left));

        map.placeRelative(GateCPStart32m,new BlockChange(BlockType.Item,"GateSpecial32mNoSteering",new Vec3(0,0,1)));
        map.placeRelative(GateCPStart16m,new BlockChange(BlockType.Item,"GateSpecial16mNoSteering",new Vec3(0,0,1)));
        map.placeRelative(GateCPStart8m,new BlockChange(BlockType.Item,"GateSpecial8mNoSteering",new Vec3(0,0,1)));
        map.placeStagedBlocks();
    }

    public static void CPFull(Map map){
    }
}

enum LeftRight
{
    Left,
    Right
}

class DiagBlockChange : BlockChange{

    static float PI = (float)Math.PI;
    LeftRight side;
    public DiagBlockChange(BlockType blockType, string model,LeftRight side) : base(blockType,model){this.side = side;}
    public DiagBlockChange(BlockType blockType, string model, Vec3 absolutePosition,LeftRight side) : base(blockType,model,absolutePosition){this.side = side;}
    public DiagBlockChange(BlockType blockType, string model, Vec3 absolutePosition, Vec3 pitchYawRoll,LeftRight side) : base(blockType,model,absolutePosition,pitchYawRoll){this.side = side;}
    public DiagBlockChange(Vec3 absolutePosition,LeftRight side) : base(absolutePosition){this.side = side;}
    public DiagBlockChange(Vec3 absolutePosition, Vec3 pitchYawRoll,LeftRight side) : base(absolutePosition,pitchYawRoll){this.side = side;}

    public override void changeBlock(CGameCtnBlock ctnBlock,Block @block){
        switch (ctnBlock.Direction){
            case Direction.North:
                block.relativeOffset(new Vec3(64,0,0));
                break;
            case Direction.East:
                block.relativeOffset(new Vec3(64,0,-32));
                break;
            case Direction.South:
                block.relativeOffset(new Vec3(0,0,-32));
                break;
            case Direction.West:
                block.relativeOffset(new Vec3(0,0,0));
                break;
        }

        switch (side){
            case LeftRight.Right:
                block.relativeOffset(new Vec3(-23.1f,0,10.6f));
                block.pitchYawRoll += new Vec3(PI * -0.148f,0f,0);
                break;
            case LeftRight.Left:
                block.relativeOffset(new Vec3(-37.3f,0,24.8f));
                block.pitchYawRoll += new Vec3(PI * 0.148f,0,0);
                break;
        }
        
        if (model != "") {
            block.blockType = blockType;
            block.model = model;
        }
        block.relativeOffset(absolutePosition);
        block.pitchYawRoll += pitchYawRoll;
    }
}