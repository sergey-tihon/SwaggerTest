module SwaggerTest

open SwaggerProvider

let [<Literal>] schema = "http://petstore.swagger.io/v2/swagger.json"
type PetStore = SwaggerProvider<schema> // Provided Types
let petStore = PetStore.Client()
