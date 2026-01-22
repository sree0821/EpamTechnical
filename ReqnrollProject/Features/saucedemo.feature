Feature: SauceDemo Order Flow
  As a user
  I want to buy a product
  So that I can complete checkout successfully

  Scenario: Complete order flow in SauceDemo
    Given I launch SauceDemo application
    And I login with valid credentials
    When I add a product to the cart
    Then the product price should be same in cart
    When I checkout the product
    Then the order should be completed successfully