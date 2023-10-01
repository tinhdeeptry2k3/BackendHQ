{
  "openapi": "3.0.1",
  "info": {
    "title": "WebHoaQua",
    "version": "1.0"
  },
  "paths": {
    "/api/Categorys/getlist": {
      "get": {
        "tags": [
          "Categorys"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Categorys"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Categorys"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Categorys"
                  }
                }
              }
            }
          }
        }
      }
    },
    "/api/Categorys/insert": {
      "post": {
        "tags": [
          "Categorys"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Categorys/update": {
      "post": {
        "tags": [
          "Categorys"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Categorys"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Categorys/delete/{id}": {
      "post": {
        "tags": [
          "Categorys"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/insert": {
      "post": {
        "tags": [
          "Orders"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/CreateOrderModel"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/CreateOrderModel"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/CreateOrderModel"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/update": {
      "post": {
        "tags": [
          "Orders"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Orders"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Orders"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Orders"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/delete/{id}": {
      "post": {
        "tags": [
          "Orders"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/getlist": {
      "post": {
        "tags": [
          "Orders"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/getbyid/{id}": {
      "post": {
        "tags": [
          "Orders"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Orders/details/{id}": {
      "get": {
        "tags": [
          "Orders"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Products/getlist": {
      "get": {
        "tags": [
          "Products"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Products"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Products"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Products"
                  }
                }
              }
            }
          }
        }
      }
    },
    "/api/Products/getbyid/{id}": {
      "get": {
        "tags": [
          "Products"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/Products"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/Products"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/Products"
                }
              }
            }
          }
        }
      }
    },
    "/api/Products/insert": {
      "post": {
        "tags": [
          "Products"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Products/update": {
      "post": {
        "tags": [
          "Products"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Products"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Products/delete/{id}": {
      "post": {
        "tags": [
          "Products"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Users/login": {
      "post": {
        "tags": [
          "Users"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateModel"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateModel"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateModel"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Users/register": {
      "post": {
        "tags": [
          "Users"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterModel"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterModel"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterModel"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Users/update": {
      "post": {
        "tags": [
          "Users"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/UpdateModel"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/UpdateModel"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/UpdateModel"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "AuthenticateModel": {
        "required": [
          "password",
          "username"
        ],
        "type": "object",
        "properties": {
          "username": {
            "minLength": 1,
            "type": "string"
          },
          "password": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      },
      "Categorys": {
        "required": [
          "name"
        ],
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      },
      "CreateOrderModel": {
        "type": "object",
        "properties": {
          "orders": {
            "$ref": "#/components/schemas/Orders"
          },
          "listProducts": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/OrderProductModel"
            },
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "OrderProductModel": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "quantity": {
            "type": "integer",
            "format": "int32"
          }
        },
        "additionalProperties": false
      },
      "Orders": {
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "nullable": true
          },
          "username": {
            "type": "string",
            "nullable": true
          },
          "address": {
            "type": "string",
            "nullable": true
          },
          "phone": {
            "type": "string",
            "nullable": true
          },
          "status": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "Products": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "type": "string",
            "nullable": true
          },
          "price": {
            "type": "integer",
            "format": "int32"
          },
          "quantity": {
            "type": "integer",
            "format": "int32"
          },
          "description": {
            "type": "string",
            "nullable": true
          },
          "category_id": {
            "type": "integer",
            "format": "int32"
          },
          "image": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "RegisterModel": {
        "required": [
          "password",
          "username"
        ],
        "type": "object",
        "properties": {
          "username": {
            "minLength": 1,
            "type": "string"
          },
          "password": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      },
      "UpdateModel": {
        "required": [
          "address",
          "fullname",
          "phone"
        ],
        "type": "object",
        "properties": {
          "fullname": {
            "minLength": 1,
            "type": "string"
          },
          "phone": {
            "minLength": 1,
            "type": "string"
          },
          "address": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      }
    }
  }
}
