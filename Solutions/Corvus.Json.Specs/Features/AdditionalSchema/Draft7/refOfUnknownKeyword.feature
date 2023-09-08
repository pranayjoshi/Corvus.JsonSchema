@draft7

Feature: Path-like unknown keyword draft7

Scenario Outline: reference of an arbitrary keyword of a sub-schema
	Given a schema file
		"""
		{
			"properties": {
				"foo": {"path/like/keyword": {"type": "integer"}},
				"bar": {"$ref": "#/properties/foo/path~1like~1keyword"}
			}
		}
		"""
	And the input data value <inputData>
	And I generate a type for the schema
	And I construct an instance of the schema type from the data
	When I validate the instance
	Then the result will be <valid>

Examples:
	| inputData        | valid |
	| {"bar": 3}       | true  |
	| {"bar": "hello"} | false |
