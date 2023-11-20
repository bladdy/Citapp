export interface Plan {
  id: number
  name: string
  description: Description[]
  price: number
}

export interface Description {
  id: number
  detail: string
}
