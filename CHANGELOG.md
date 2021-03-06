# [6.0.0](https://github.com/christides11/Character-Action-Framework/compare/v5.0.0...v6.0.0) (2020-10-31)


### Code Refactoring

* Made BoxDefinitionBase the default assumed class. ([1bf3769](https://github.com/christides11/Character-Action-Framework/commit/1bf3769678ce379fbe4b6b46d1008d09ff686779))
* Removed deltatime from Simulation method variables. ([389c187](https://github.com/christides11/Character-Action-Framework/commit/389c187af64c3d00e923c2beafbefda4cec948d3))
* Removed status effects. ([1b6076d](https://github.com/christides11/Character-Action-Framework/commit/1b6076dca2c82b699ee69951eafef3d544d39f2b))
* Removed styleGain variable from BoxGroup. ([5e02bf1](https://github.com/christides11/Character-Action-Framework/commit/5e02bf1c45d45859413d713410a610e4e4487093))
* Removed variables from AttackDefinition. ([f3ed16f](https://github.com/christides11/Character-Action-Framework/commit/f3ed16f127cfa872fe96661857d46d34917adeea))
* Replaced GetCenter for GetGameObject in ITargetable. ([30de643](https://github.com/christides11/Character-Action-Framework/commit/30de643e44c821861390fcfac5fd5dc19c3d511e))
* Take InputDefinition directly for CheckStickDirection. ([48d7c65](https://github.com/christides11/Character-Action-Framework/commit/48d7c653ec9c851158aa9cb8cd9314c07e0c183e))


### Features

* Added EntityPhysicsManagerBase. ([1f6d586](https://github.com/christides11/Character-Action-Framework/commit/1f6d586344b43512cb7115501ea99da31bf036c1))
* Added HurtInfoBase to store hurt information. ([b28032b](https://github.com/christides11/Character-Action-Framework/commit/b28032ba8b2084a6109e6b5381e38720d1f3a1e2))
* Added StateHurtboxDefinition. ([36e3dff](https://github.com/christides11/Character-Action-Framework/commit/36e3dffc02db9ba9d2da17e5c71b1c4ba0c76d8f))
* Editor for StateHurtboxDefinition. ([9d26e39](https://github.com/christides11/Character-Action-Framework/commit/9d26e391eebf39463275503720f27ad0b9488bde))
* Functionally of EntityHurtboxManager. ([8d7e273](https://github.com/christides11/Character-Action-Framework/commit/8d7e27355742a0507a3c166887ad98423b124d20))


### BREAKING CHANGES

* Status effects should be handled user-side, outside of what CAF needs to do.
* PhysicsManager now allows for your own implementation, with two given implementations for 3D and 2D.
* Instead of passing the huirt variables directly in OnHurt, instead allow the user to define what should be passed in their own HurtInfoBase. Avoids assuming how the user will implement this method.
* Take InputDefinition directly now for CheckStickDirection. Avoids forcing floats in the user's system.
* With this, the center of the object and any other needed data can be grabbed, while also not assuming the numeric type to be a Vector3.
* Removed deltatime variables from method relating to the simulation. Part of changes to make using fixed point variables easier.
* BoxDefinition was replaced with BoxDefinitionBase in any case that it was reference. This change was made mainly to allow changing the type of the variables used (important if you want fixed point variables).
* Removed both heightRestriction and gravityScaleAdded from AttackDefinition. Should be implemented by the user.
* Removed styleGain variable from BoxGroup. This should be defined by the user as they might either not use a style meter at all or not want to use floats.

# [5.0.0](https://github.com/christides11/Character-Action-Framework/compare/v4.1.0...v5.0.0) (2020-09-11)


### Code Refactoring

* Changed Hitbox to HitboxBase. ([89c135d](https://github.com/christides11/Character-Action-Framework/commit/89c135dfe2ddb80eb0894f92119d58d5a26956e3))


### Features

* Added reset method to LookHandler. ([317235a](https://github.com/christides11/Character-Action-Framework/commit/317235a1e38b56b24e83c6c114e38881c87f6df2))
* Attack events can now check for input. ([9409de5](https://github.com/christides11/Character-Action-Framework/commit/9409de5c6ee7b93d0b43e6754e96821a6d66af37))


### BREAKING CHANGES

* inputs sequences put into their own class, separate from attacks. Makes it easier to define and read input for things besides attacks.
* Changed Hitbox to HitboxBase to better reflect it's usage.

# [4.1.0](https://github.com/christides11/Character-Action-Framework/compare/v4.0.0...v4.1.0) (2020-08-25)


### Features

* Added methods for inertia redirection. ([2672ff2](https://github.com/christides11/Character-Action-Framework/commit/2672ff27eb0d750817113917339d112bd8d5f9de))

# [4.0.0](https://github.com/christides11/Character-Action-Framework/compare/v3.1.0...v4.0.0) (2020-08-21)


### Code Refactoring

* Changed Team property to a method. ([a22502b](https://github.com/christides11/Character-Action-Framework/commit/a22502be88e631e29a39f2962e0e834e15622d93))
* Changed to using HitInfoBase. ([d1717dd](https://github.com/christides11/Character-Action-Framework/commit/d1717dd26db209cf1aec630376b6e6ab171adfb9))
* Removed HealthManager. ([d3c0749](https://github.com/christides11/Character-Action-Framework/commit/d3c0749377ed077ab72fff19cccb54ae2cc49de6))
* Renamed Controller to Manager. ([903ef44](https://github.com/christides11/Character-Action-Framework/commit/903ef44ed7d0620c55d6d2f082a394245012f625))
* Split Hitbox into 2D and 3D. ([23705e6](https://github.com/christides11/Character-Action-Framework/commit/23705e695d590777e0fb022139e5c44f517b6326))


### Features

* Added charge level vars to EntityCombatManager. ([066b55c](https://github.com/christides11/Character-Action-Framework/commit/066b55cbcfef88a0658705b97898f0f6ff35ff36))
* Added healing support, hit info rework. ([013265d](https://github.com/christides11/Character-Action-Framework/commit/013265d234f1fd7eb5c421dbe468bb3d5becdaa2))
* Added hitstop/stun enter and added events. ([4f5cd7d](https://github.com/christides11/Character-Action-Framework/commit/4f5cd7dbdefc18e76fdf32cf2ad82c45c557f86b))
* Added method to get hit list. ([77d6a90](https://github.com/christides11/Character-Action-Framework/commit/77d6a90f29611aed84811f4ddf564b48023c02ce))
* Added team parameter to Hitbox Initialize. ([56a2699](https://github.com/christides11/Character-Action-Framework/commit/56a2699eefa9cb5c321e5542b0b085f22fcf7ea3))
* Charge Levels ([9b1247a](https://github.com/christides11/Character-Action-Framework/commit/9b1247aba6e3e379fbcb0b27c13ba05816348e73))
* Moveset changing. ([60c2440](https://github.com/christides11/Character-Action-Framework/commit/60c24408ee3906607847b1b18aab36b95fd8d63a))
* Multiple attack editor windows can be opened. ([b8dba47](https://github.com/christides11/Character-Action-Framework/commit/b8dba47fc01a1bc3082dec2c2f85cf03a1e73201))
* StateManager related events. ([5f2d5d9](https://github.com/christides11/Character-Action-Framework/commit/5f2d5d9ab589970fbcf5984a4f95e7efb8da384c))
* Support for charge level related hitboxes. ([28418b2](https://github.com/christides11/Character-Action-Framework/commit/28418b2a0921b96b3725c62d61dedb240495091c))
* Upgraded to 2019.4.7f1. ([b5b8940](https://github.com/christides11/Character-Action-Framework/commit/b5b8940db1467282ec3b36ae07a77a3368dc97ad))
* Upgraded to 2019.4.8f1 ([3d81308](https://github.com/christides11/Character-Action-Framework/commit/3d81308917a258cc509d183e089b2981ddeb9ad6))
* Various events for CombatManager related task. ([4fecc2f](https://github.com/christides11/Character-Action-Framework/commit/4fecc2f4b455b4789ad7d1066578296be272242d))


### BREAKING CHANGES

* Initialize now takes a team parameter. Useful in case you want to assign entities to teams and define who they can attack.
* Renamed anywhere using controller to manager for EntityManager.
* Hitbox is now separated into Hitbox3D and Hitbox2D, with Hitbox being the base class of the two.
* Users may want the entity's team to be exposed in the inspector, and they may also want it to be defined by a enum. This makes sure that case is covered.
* Renamed delegates.
* Removed HealthManager since a user might want to store their health values in many different ways, such as ints or fixed point values.
* Now using HitInfoBase in places where HitInfo was being used. Makes system more extendable.
* HitStop and HitStun are now properties instead of fields.
* Upgraded to 2019.4.7f1.

# [3.1.0](https://github.com/christides11/Character-Action-Framework/compare/v3.0.0...v3.1.0) (2020-08-07)


### Features

* Added data for charged attacks. ([e1ca903](https://github.com/christides11/Character-Action-Framework/commit/e1ca9037decaf7a35681e646d02c6e5e33661ada))

# [3.0.0](https://github.com/christides11/Character-Action-Framework/compare/v2.0.0...v3.0.0) (2020-08-06)


### Code Refactoring

* Removed detect box support. ([3c64b5b](https://github.com/christides11/Character-Action-Framework/commit/3c64b5b1b5a92e79766722c46ccf828a5f2007eb))


### BREAKING CHANGES

* Removed detectbox support. Hitboxes can achieve the same effect with no damage/hitstun.

# [2.0.0](https://github.com/christides11/Character-Action-Framework/compare/v1.0.0...v2.0.0) (2020-08-06)


### Styles

* Formatting. ([e60f3cf](https://github.com/christides11/Character-Action-Framework/commit/e60f3cffed75b5a9350f23d69ea7b5e82392fe82))


### BREAKING CHANGES

* Renamed SetController.

# 1.0.0 (2020-07-30)


### Features

* semantic versioning ([171259b](https://github.com/christides11/Character-Action-Framework/commit/171259b88b777269ab7f233127d771fcb7856548))
