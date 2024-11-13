[<Struct>]
type QTPoint<[<Measure>]'x,[<Measure>]'y> = { X: float<'x>; Y: float<'y> }

[<Struct>]
type K2DTreeNode<[<Measure>]'x, [<Measure>] 'y, 'T> = { Point : QTPoint<'x,'y>; Value : 'T }

[<Struct>]
type K2DTreeBranch<[<Measure>]'x, [<Measure>] 'y, 'T> = { BranchPoint : QTPoint<'x,'y>; Left : K2DTree<'x,'y,'T>; Right : K2DTree<'x,'y,'T> }
and K2DTree<[<Measure>]'x, [<Measure>]'y, 'T> =
    | LeafNode of K2DTreeNode<'x, 'y, 'T>[]
    | InternalNode of K2DTreeBranch<'x, 'y, 'T>