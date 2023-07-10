module MembershipTests

open MembershipTypes
open MembershipFunctions
open Xunit

[<Fact>]
let ``Member subscribes to magazine`` () =
    let magazineSubscription = Magazine
    let expected = MemberSubscription Magazine
    
    let actual = Subscribe magazineSubscription 
    
    Assert.Equal<MemberSubscription>(expected, actual)

