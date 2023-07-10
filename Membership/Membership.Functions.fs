module MembershipFunctions

open MembershipTypes

let Subscribe (subscription : MySubscriptions) ( publishingFrequency : PublishingFrequency ) =
    let memberSubscription = { Subscription = subscription; ReceivingSubscriptionFrequency = publishingFrequency }
    memberSubscription

